# WisejDataGridView
Demo application showing a Wisej project with a DataGridView. Based on https://github.com/JulieHirt/WisejJulieBodettev3
Functionality to double-click on an entry to edit it is unfinished.

Data is stored in SQLite, and can be viewed via table in the Wisej application.
Users can add organizations to the table via the GUI, with a name, street, zip, city and country.
The zip must be an integer- you get a warning if it is not :)

The SQlite database is stored in the file database.sqlite3
If you want to read/edit the SQlite database directly, you can do so via DB Browser, which you can download here: https://sqlitebrowser.org/
