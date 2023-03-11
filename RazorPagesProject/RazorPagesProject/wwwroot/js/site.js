// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const grades = [
    { name: "John", grade: 90 },
    { name: "Mary", grade: 85 },
    { name: "Bob", grade: 92 },
    { name: "Alice", grade: 87 },
    { name: "Mark", grade: 95 },
];

// Calculate average grade
const avgGrade = grades.reduce((total, grade) => total + grade.grade, 0) / grades.length;

// Display average grade
document.getElementById("avg").textContent = avgGrade.toFixed(2);

// Find best performing students
const bestPerformers = grades.filter(grade => grade.grade >= 90);

// Display best performing students
const bestList = document.getElementById("best");
bestPerformers.forEach(grade => {
    const li = document.createElement("li");
    li.textContent = grade.name + " - " + grade.grade;
    bestList.appendChild(li);
});