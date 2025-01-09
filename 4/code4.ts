const states = {
    SP: 67836.43,
    RJ: 36678.66,
    MG: 29229.88,
    ES: 27165.48,
    Others: 19849.53,
};

const total = Object.values(states).reduce((acc, val) => acc + val, 0);

for (const state in states) {
    console.log(
        `Percentage of ${state}: ${(states[state] / total * 100).toFixed(2)}%`
    );
}
