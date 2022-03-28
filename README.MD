# EZPZTXT
There are a lot of programs out there that can do a lot of cool stuff with your texts, and it is often easiest to use them when your texts are in separate, flat .txt files. However, there’s a problem: Getting language data out of your spreadsheet files (e.g., XLSX, CSV, TSV, etc.) and into plain-text files is a time-consuming (and occasionally confusing) process. If only there was a low-effort, easy peasy way to do this without having to tinker with archaic scripts, file encoding issues, etc., life would be amazing.

Enter EZPZTXT (Easy Peasy Tee Ex Tee). This program will handle all of the “under the hood” work for you, allowing you to spend your time actually analyzing your texts. Huzzah!

# Features and Use
## Input Data Files

EZPZTXT takes your text-based spreadsheet files and saves your selected columns to .txt files. EZPZTXT is built to work “out of the box” with CSV files and other delimited data formats, such as TSV and delimited-TXT. If your spreadsheets are saved in another format (e.g., XLS, XLSX, ODS, SLK), you can easily “Save As” a supported format (e.g., CSV) from your favorite spreadsheet editor, like MS Excel or Apache OpenOffice.

EZPZTXT works with data files of all sizes, and should have no problems with even the largest of datasets. This is because it “streams” your data rather than loading the whole dataset at once. This software has been tested with datasets that have thousands of columns and hundreds of millions of rows without any issues.

Note that EZPZTXT is not very robust to malformed data files. There are standardized guidelines for the formatting of delimited datasets (e.g., CSV Standardization), and most spreadsheet editors are very aware of (and compliant with) these formatting standards. If your data file came from (or can be edited with) any of the commonly-used spreadsheet programs, then this software should have no problems with your dataset.

 
## Basic Use

The steps for the most basic use of EZPZTXT are fairly straight-forward.

1. Load your spreadsheet file
2. Using the data preview window, make sure that your Options for Reading Data Files are correct. Tweak these settings as necessary, and Reload the preview after making changes.
3. Click on the Write Text Files button.
4. Choose what columns you want to use for filenames, and which columns contain the text that you would like to write to files. You can also choose to create subfolders from columns in your dataset.
5. Let EZPZTXT do the rest of the work!

Beyond this basic use, there are a lot of features that you can use to customize how EZPZTXT reads/writes your data. The remainder of this page will outline each of these options/features.

## Options for Reading Data File

### Data column delimiter(s)
This is one of the most basic properties of a delimited data file: the character that is used to denote new columns. This is most commonly going to be a comma, a semicolon, or a tab. Note that for tabs, you may need to copy/paste a tab into this box from text editor.

### Fields enclosed in quotes
Text formatting inside of a delimited data file can get a bit complicated. For example, how does a program know that a linebreak in a text field (e.g., a new paragraph) isn’t a completely different line of data? The most common way that these types of issues are handled is through standardized quoting practices. You will almost always want to set this option to “True” unless you know for sure that your data file is formatted differently.

### Data has a header row
Set this to “True” if your data file has variable names in the first row.

Important note about your header row: Your column names should never be very long. Rather than using a long description for a column, you should generally opt for “variable names” instead. So, rather than having a column name be:

“What would you like for us to know outside of what you’ve told us already?”

You should opt for a column name like:

“OtherInfo”

### File Encoding
Set the text encoding for your input file. The .txt files that the program outputs will be the same encoding.  If you are experiencing odd characters or broken words in your output, this is likely being caused by a mismatch between your selected encoding and the encoding used in your data file. At startup, EZPZTXT automatically selects your system’s default encoding.

Common encodings include utf-8, utf-16, iso-8859-1, and windows-1252. Most web data, for example, is encoded in utf-8. If you have things like emoji that aren’t displaying properly, try utf-8 encoding first to see if that fixes things.

 
## Options for Writing Text Files

### Append or Overwrite
Do you want each row of data to be appended text into already-existing files or to overwrite existing files? For example, if the first row of your CSV file is going to be written to “Participant_1.txt”, and the next row is also supposed to be written to “Participant_1.txt”, then you’d want to use “Append”. Otherwise, the second row of data will be used to overwrite the text file generated for the first row of data. As a note, if you use “Append”, you’ll want to make sure that you tell EZPZTXT to save your output to a new location. If you do not do this, you may end up accidentally adding new text to files that you did not intend to.

Important note about this option: Even if you select “Overwrite”, this option will not wipe old files from your folder. If you ran the program once and need to redo/rerun it, you will want to manually delete your old files.

### Separate files for each text column
By default, all text columns in a row will be saved to the same output file. However, we sometimes have multiple texts per row that we want to save to separate files instead of putting all of the text in the same file. For example, if you have participant writing where they have texts for Time 1 and Time 2, you might want to analyze these texts separately rather than just lumping all of the language data together. If this is the case, you’d want to set this option to “True”, and each text column will be output to its own file.

### New subfolder every N rows
This option is here to prevent “folder bloat”. Essentially, if you are outputting a large number of .txt files (i.e., >= 100,000), you want to make sure that they’re not all in the same folder, as this can cause your computer’s OS to have some problems. You might not need to use this feature if you are creating subfolders in other ways (see the “Column Selection” section below).

Important note about this option: It might be a little counter-intuitive, but this option does not necessarily mean that your resulting output will be “N files per folder”. Instead, this means that each folder can have no more than N files, but they can potentially have less. It’s a bit confusing, but doing it this way means that the program can work faster. Otherwise, it would have to check each folder and manually count the number of files before it could create each new file, which could get extremely slow. This is all a very long-winded way of saying that if you aren’t seeing N files in each of your folders, that doesn’t necessarily mean that something is wrong with the program 🙂

### Filename delimiting character
If you are using multiple columns to construct filenames for your output files, this is the character that will be used to separate the filename features.

### RegEx Removal
Regular Expressions (RegExes) are a way to identify patterns in text in a very generalized way. For example, \d will find any number in a text, and \d:\d\d would be able to capture any pattern with a number, a colon, then 2 more numbers (e.g., 2:45, 1:23, etc.). The RegEx Removal feature will allow you to specify (using regular expressions) different patterns that you want to remove from your texts prior to putting them into .txt files. This feature is here to save you time down the road — for example, if you’re wanting to remove hashtags from tweets as you’re saving your .txt files.

RegExes can be somewhat tricky to learn, but they are extremely powerful. Use them to remove any patterns from your texts that would get in the way of cleanly separating your speakers.

A great resource for learning about RegExes is https://www.regular-expressions.info. Most of the time when using this software, you’ll be need to construct RegExes that are fairly simply by most standards. For most timestamp formats, for example, you can find plenty of places online where people have already created the best RegEx patterns for capturing/cleaning them up, which means that you don’t have to worry about making them from scratch.

### Append Row Number to Filename
This will do exactly what the name implies. As EZPZTXT is working through your input file, it will append the row number to each filename that it writes, ensuring that each and every row is written to a unique file.
Column Selection

### Create Subfolders from
This feature is optional. Select which columns you would like to use to create subfolders for your .txt files. Below this box, there is a preview that will show you the structure of your subfolders. The order in which you click the boxes will determine the particular structure. For example, if you have a CSV file that contains multiple texts per each author, and has the year of each text, this will allow you to nest “Author within Year” or “Year within Author”.

### Create Filenames from
Which columns would you like to use for your filenames?

### Columns with Text
Which columns contain the text that you would like to save to .txt files?

### Automatically fix invalid filenames and paths
This feature will help to make sure that your output filenames will work with your operating system. For example, question marks (?) are typically not allowed, but your dataset might not be set up to account for this. This feature will automatically fix “broken” filenames and folders. It is highly recommended that this feature be left on, although nothing bad will happen if you turn it off — EZPZTXT might just give you a lot of messages about invalid filenames.

## Set Conditionals

This feature allows you to be a bit more selective about which rows you include/exclude when making your text files. For example, what if you want to exclude any row where the person’s Username contains the word “admin”? This can easily be set using this feature.

In order for any given row to be included in your output, all rules have to be met.
