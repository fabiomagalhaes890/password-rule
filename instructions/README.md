## Question 1
### Part 1

You are a security expert attempting to break into a company which paid you to do so. By exploiting security flaws you discover that valid passwords must follow a certain pattern.

Pattern rules:
- The password must be between 184759-856920.
- At least two adjacent digits must be the same (like 22 in 122346).
- Starting from left to right, digits only increase or stay the same (like `111237` or `135678`). 

Examples:  
`222222` is valid (double `22`, never decreases).  
`236775` is not valid (decreasing pair of digits `75`).  
`345789` is not valid (no double).  

Before attempting brute force you would like to know how many possible combinations of the password can exist. How many passwords exist following these rules?

### Part 2

After rechecking your findings you noticed there was an additional rule you missed: You must have at least one group of *exactly* two of the same characters.

For Example:  
`334478` is valid because the digits never decrease and all repeated digits are exactly two digits long.  
`347779` is not valid (the repeated `7` is adjacent three times, `777`).  
`444557` is valid (`4` is repeated more than twice but it still contains a double `55`).  

How many passwords exist following these rules?
`There are 1380 passwords`
