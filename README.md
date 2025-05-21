# RetailSalesApp
Retail Sales Application - Windows Forms

 Platform:
- C#
- Windows Forms (.NET Framework 4.8)
- SQL Server (Local)
- ADO.NET
- Logging to text file

 How to Run:
1. Open the solution file: RetailSalesApp.sln in Visual Studio.
2. Make sure SQL Server is running and database "RetailDB" is created.
3. Run the application .
4. The Sales Entry Form will load by default.
5. Use the “Report” button to open the Sales Report window if available.

Features Implemented:

1. **Sales Entry Form** (FrmSalesEntry):
   - ComboBox to select item from TB_ITM.
   - NumericUpDown to enter quantity (> 0).
   - Auto-calculates Subtotal, VAT (16%), and Total.
   - Saves sales to TB_Sales on "Save Sale" button.
   - Logs each sale in AppLogs.txt file in the application folder.
   - Displays today's sales in a DataGridView.

2. **Sales Report Form** (FrmSalesReport):
   - Two DateTimePickers to filter by date.
   - Filter button retrieves all sales between selected dates.
   - Shows:
     - Total Quantity Sold
     - Total SubTotal
     - Total VAT
     - Total Final Amount


Estimated Time Taken:
~3-4 hours

Developed by: Sura (for First Solution for Software)
