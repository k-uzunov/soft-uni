function solve(month, year) {
    let days = new Date(year, month, 0).getDate();
    console.log(days);
}

solve(2, 2021);