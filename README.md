# nameSum
A simple C# console application that calculates the sum of English letters in a name using LINQ. (A=1, B=2, C=3, ... Z=26)

### Features
- Letter to Number Conversion
- Invalid Character Detection
- Ignore Whitespace
- Exit Command

### How It Works

1. Ask's User Input
2. Input Validation
   - If the Input is empty the user will get asked to enter something
   - If the input contains invalid characters the user will get notified that invalid characters are being removed from the calculation
3. Calculation
   - Only valid English letters are processed. (A-Z)
   - Each letter is converted to lowercase
   - The value of a letter is calculated by subtracting the ASCII value of 'a' from the letter's ASCII value and then adding 1.
   - For example:
   - Values of all processed letters are summed together and displayed
