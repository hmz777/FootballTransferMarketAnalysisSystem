# Football Transfer Market Analysis System
A simple CLIPS expert system that uses the FIFA 21 player database to give player recommendations based on user parameters.

The project uses C# and Windows Forms as GUI for the system and CLIPS for the actual processing of data.

## The C# Part
The C# code is responsible for: 
- Constructing the `deftemplate` dynamically from the database schema.
- Reading and parsing the data from the database (.csv file).
- Converting the parsed data into facts by constructing a `deffacts` construct and asserting all the data pulled from the database in order for the CLIPS system to make use of them.
- Validating user parameters and converting them into facts within a separate `deffacts` construct.
- Constructing a `deftemplate` for the average skill score in order to classify if a player is suitable for a certain play style.
- Read the `UserSystem.clp` which represents the actual CLIPS system that does the data processing.
- Combine the constructed CLIPS code with the `UserSystem.clp` file to create `System.clp`.
- Creating a batch file `Clips.bat` that does the `(Load)`, `(Reset)` and `(Run)` then `(Exit)` commands via CLIPS.
- Spawning a process and passing the `Clips.bat` file to be executed by `CLIPSDOS.exe` which is the command line version of clips.
- Capturing the output from `CLIPSDOS.exe`, parsing it, then displaying it in a `ListView`.

## The CLIPS Part
The CLIPS code contains a set of rules and functions that does the following:
- Process all the asserted player data by retracting all the players that don't fit the user parameters.
- Calculate the average score of each player skill for the remaining players after the initial processing done by the rules.
- Further process player data by passing them to `FilterByPlayStyle` function that uses the average scores of each skill to determine if a player is suitable for a certain play style. 
- Lastly, the `Result` rule is executed to output all the remaining players that match the user parameters in a certain format that is known by the C# code in order to parse the data and display it correctly.

# Author
**Hamzi Alsheikh**

**Website: [https://www.hamzialsheikh.tk](https://www.hamzialsheikh.tk)**
