// Show/hide solution for the current sudoku puzzle
function hideSolution() {
    var sudokuTable = document.getElementById("solutionTable");

    if (sudokuTable.style.display === "none") {
        sudokuTable.style.display = "grid";
    } else {
        sudokuTable.style.display = "none";
    }
}