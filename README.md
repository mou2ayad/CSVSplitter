# CSVSplitter
Main Goal: Develop a GUI using C#, which imports data from the attached CSV file and displays them in a window using the DataGridView-Control (WinForms) or DataGrid-Control (WPF).
Details:
- Create a graphical user interface, consisting out of a DataGridView-/DataGrid-Control and necessary buttons for other features
- With the press of a button, the user shall be able to select the attached books list (Books.csv) and import it automatically into the GUI and into the DataGridView/DataGrid
- Column Types:
o “Title”, “Author”, “Price” and “Year”: text columns
o “Binding”: combo box column
o “In Stock”: check box column
o “Description”: not displayed. Create a button column to show the description in a tool tip, message box, etc. when the user presses the button
- Rows with books, that are not in stock shall be highlighted
- The text of each cell in the “Price” column shall be colored according to its value (color gradient from highest to lowest price)
- Add another button which deletes all books from DataGridView/DataGrid, that are not in stock
