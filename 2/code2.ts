function isFibonacci(number: number): void {
    let a = 0, b = 1, c = 0;

    while (c <= number) {
        if (c === number) {
            console.log("The number belongs to the Fibonacci sequence.");
            return;
        }
        c = a + b;
        a = b;
        b = c;
    }

    console.log("The number does not belong to the Fibonacci sequence.");
}

// Example usage:
isFibonacci(21);
