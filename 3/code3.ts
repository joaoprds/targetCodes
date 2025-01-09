const revenues: number[] = [1000, 0, 2000, 3000, 0, 0, 1500, 4000, 500, 0, 2500];
const validDays = revenues.filter((value) => value > 0);
const average = validDays.reduce((acc, val) => acc + val, 0) / validDays.length;

console.log("Lowest revenue:", Math.min(...validDays));
console.log("Highest revenue:", Math.max(...validDays));
console.log(
    "Days above the average:",
    validDays.filter((value) => value > average).length
);
