# PasswordGenerator
The classlibrary **PasswordGenerator** allows generate random password.
Password can contain from capital Letters, small letters, digits and special characters.

``` c#
private const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string digits = "0123456789";
    private const string specChar = "!@#$%^&*~`?/";
    private const string allChars = capitalLetters + smallLetters + specChar;
    private static Random rnd = new Random();
    
```

**The output** chows the randowm generated password, and the numbers of elements of password:

```c#
"Your new password is:
j^@&9tYYhLe`U?C
Your password consists of 15 elements
```




