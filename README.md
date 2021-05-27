# Raindrops

## Project Goal

The goal of this project is to create a function that takes a number `n` as it's input and returns a string whose contents depends on the factors of `n` in a similar fashion to the common [Fizz buzz](https://en.wikipedia.org/wiki/Fizz_buzz) problem. In this case the returned string depends on whether the input number is a factor of 3, 5, 7, a combination of these, or none of these, in the following fashion.

* If 3 is a factor of the `n`, output `Pling`
* If 5 is a factor of the `n`, output `Plang`
* If 7 is a factor of the `n`, output `Plong`
* If `n` has some combination of the above conditions are met output a concatenation of the outputs, in the order they are given above.
* If none of the above apply return `n`'s digits

For example

- 28's factors are 1, 2, 4, 7, 14 and 28
  - 7 is a factor of 28
  - `n` = 28 returns the string `Plong`
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30
  - Both 3 and 5 are factors of 30
  - `n` = 30 returns the string `PlingPlang`
- 34 has four factors: 1, 2, 17, and 34
  - `n` = 34 returns the string `34`

