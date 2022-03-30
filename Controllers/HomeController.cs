using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SudokuGenerator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Rotativa.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace SudokuGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // 2D array with sudoku values
        private int[,] _sudokuSolution = new int[9,9];
        private int[,] _sudokuValues = new int [9,9];

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Startup View with empty sudoku cells and disabled "Solution" button
        public IActionResult Index()
        {
            ViewBag.Value = _sudokuValues;
            ViewBag.Solution = _sudokuValues;
            ViewBag.EnableSolution = false;

            var data = new byte[_sudokuValues.Length];
            HttpContext.Session.Set("Values", data);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Printing single sudoku puzzle without solution
        public ActionResult PrintSudoku()
        {
            return new ViewAsPdf("PrintSudoku");
        }

        // Printing single sudoku puzzle with solution
        public ActionResult PrintSolution()
        {
            return new ViewAsPdf("PrintSolution");
        }

        // Main method, creating a filled sudoku puzzle of chosen difficulty (easy by default)
        [HttpPost]
        public ActionResult Index(string difficulty = "Easy")
        {
            List<int> excludedValues = new List<int>();
            List<int> column = new List<int>();
            List<int> row = new List<int>();

            Random rand = new Random();
            int randomValue;

            // 81 tries, since there are 9 cells with 9 possibles values in each
            int triesCount = 81;
            int nextYCell = 0;
            int nextXCell = 0;

            // Algorithm for randomizing a full, complete sudoku 
            for (int k = 0; k < 9; k++)
            {
                for (int j = 0 + nextYCell; j < 3 + nextYCell; j++)
                {
                    for (int i = 0 + nextXCell; i < 3 + nextXCell; i++)
                    {
                        randomValue = rand.Next(1, 10);

                        row = Enumerable.Range(0, _sudokuValues.GetLength(1))
                        .Select(x => _sudokuValues[j, x])
                        .ToList();

                        column = Enumerable.Range(0, _sudokuValues.GetLength(0))
                        .Select(x => _sudokuValues[x, i])
                        .ToList();

                        while (excludedValues.Contains(randomValue) || row.Contains(randomValue) || column.Contains(randomValue))
                        {
                            randomValue = rand.Next(1, 10);
                            triesCount--;

                            // Start again if all possible combinations have been already tested
                            if (triesCount <= 0)
                            {
                                _sudokuValues = new int[9, 9];
                                Index(difficulty);
                                return View();
                            }
                        }
                        triesCount = 81;
                        _sudokuValues[j, i] = randomValue;
                        _sudokuSolution[j, i] = randomValue;
                        excludedValues.Add(randomValue);
                    }
                }
                // Move to next column
                nextXCell += 3;
                excludedValues.Clear();

                // Move to next row
                if (nextXCell > 6)
                {
                    column.Clear();
                    row.Clear();
                    nextXCell = 0;
                    nextYCell += 3;
                }
            }

            // Finalize creating a sudoku and set required Session data 
            CreateSudoku(difficulty);
            SetSessionData(difficulty);

            ViewBag.Solution = _sudokuSolution;
            ViewBag.Value = _sudokuValues;
            ViewBag.EnableSolution = true;

            return View();
        }

        // Set Session data for PrintSudoku and PrintSolution Views
        public void SetSessionData(string difficulty)
        {
            var sudokuArray = new byte[_sudokuValues.Length];
            int index = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudokuArray[index] = Convert.ToByte(_sudokuValues[i, j]);
                    index++;
                }
            }

            HttpContext.Session.Set("Values", sudokuArray);
            HttpContext.Session.SetString("Difficulty", difficulty);

            sudokuArray = new byte[_sudokuSolution.Length];
            index = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudokuArray[index] = Convert.ToByte(_sudokuSolution[i, j]);
                    index++;
                }
            }

            HttpContext.Session.Set("Solution", sudokuArray);
        }

        // Take filled sudoku and remove values from random cells based on chosen difficulty
        public void CreateSudoku(string difficulty)
        {
            List<int> excludedValues = new List<int>();
            List<int> randomValues = new List<int>();

            Random rand = new Random();

            int randomValue = rand.Next(1, 10);
            int range = rand.Next(4, 7);
            int nextYCell = 0;
            int nextXCell = 0;

            for (int k = 0; k < 9; k++)
            {
                // Easy -> 3 to 6 values in each large cell
                // Medium -> 2 to 5 values in each large cell
                // Hard -> 1 to 4 values in each large cell
                if (difficulty == "Easy")
                {
                    range = rand.Next(4, 7);
                }
                else if (difficulty == "Medium")
                {
                    range = rand.Next(5, 8);
                }
                else if (difficulty == "Hard")
                {
                    range = rand.Next(6, 9);
                }

                for (int i = 0; i < range; i++)
                {
                    while (excludedValues.Contains(randomValue))
                    {
                        randomValue = rand.Next(1, 10);
                    }

                    excludedValues.Add(randomValue);
                    randomValues.Add(randomValue);
                }

                for (int j = 0 + nextYCell; j < 3 + nextYCell; j++)
                {
                    for (int i = 0 + nextXCell; i < 3 + nextXCell; i++)
                    {
                        if (randomValues.Contains(_sudokuValues[i, j]))
                        {
                            _sudokuValues[i, j] = 0;
                        }
                    }
                }
                // Move to next column
                excludedValues.Clear();
                randomValues.Clear();
                nextXCell += 3;

                // Move to next row
                if (nextXCell > 6)
                {
                    nextXCell = 0;
                    nextYCell += 3;
                }
            }
        }
    }
}