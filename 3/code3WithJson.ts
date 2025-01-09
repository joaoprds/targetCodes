import * as fs from "fs";

interface Revenue {
    dia: number;
    valor: number;
}

const data = fs.readFileSync("data/revenue.json", "utf8"); 
const revenues: Revenue[] = JSON.parse(data);

const validDays = revenues.filter((r) => r.valor > 0);
const min = Math.min(...validDays.map((r) => r.valor));
const max = Math.max(...validDays.map((r) => r.valor));
const average = validDays.reduce((sum, r) => sum + r.valor, 0) / validDays.length;
const daysAboveAverage = validDays.filter((r) => r.valor > average).length;

console.log(`Smallest revenue: ${min}`);
console.log(`Largest revenue: ${max}`);
console.log(`Days above average: ${daysAboveAverage}`);
