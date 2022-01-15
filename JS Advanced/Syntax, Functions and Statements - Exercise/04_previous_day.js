function previousDay(year, month, day) {
    let prevDay = new Date(Number(year),Number(month-1) , Number(day-1));

    console.log(`${prevDay.getFullYear()}-${prevDay.getMonth()+1}-${prevDay.getDate()}`);
}
previousDay(2016, 10, 1);