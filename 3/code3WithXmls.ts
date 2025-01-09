import * as fs from "fs";
import { parseString } from "xml2js";

interface Revenue {
    dia: number;
    valor: number;
}

const xmlData = fs.readFileSync("data/revenue.xml", "utf8");
parseString(xmlData, (err, result) => {
    if (err) {
        console.error("Error parsing XML:", err);
        return;
    }

    const revenues: Revenue[] = result.rows.row.map((r: any) => ({
        dia: parseInt(r.dia[0]),
        valor: parseFloat(r.valor[0]),
    }));

    const validDays = revenues.filter((r) => r.valor > 0);
    const min = Math.min(...validDays.map((r) => r.valor));
    const max = Math.max(...validDays.map((r) => r.valor));
    const average = validDays.reduce((sum, r) => sum + r.valor, 0) / validDays.length;
    const daysAboveAverage = validDays.filter((r) => r.valor > average).length;

    console.log(`Smallest revenue: ${min}`);
    console.log(`Largest revenue: ${max}`);
    console.log(`Days above average: ${daysAboveAverage}`);
});
