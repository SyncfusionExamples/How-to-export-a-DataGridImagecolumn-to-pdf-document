# How to export a DataGridImagecolumn to pdf document?
In this article, we will show you how to export a DataGridImagecolumn to pdf document in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
The below code illustrates how to export a DataGridImagecolumn to pdf document in dataGrid.
```
 <ContentPage.BindingContext>
     <local:EmployeeViewModel/>
 </ContentPage.BindingContext>

 <StackLayout>
    <syncfusion:SfDataGrid x:Name="dataGrid" VerticalOptions="FillAndExpand" AutoGenerateColumnsMode="None" ColumnWidthMode="Auto"
                           ItemsSource="{Binding Employees}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                              Format="#"
                                              HeaderText="Employee ID" />
            <syncfusion:DataGridTextColumn MappingName="Name"
                                           HeaderText="Employee Name" />

            <syncfusion:DataGridImageColumn MappingName="EmpImage"
                                            Width="75"
                                            HeaderText="Image" />
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
    <Button Text="ExportToPdf" Clicked="Button_Clicked"> </Button>
</StackLayout>
```

## C# 
```
private void Button_Clicked(object sender, EventArgs e)
{
    MemoryStream stream = new MemoryStream();
    DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
    DataGridPdfExportingOption option = new DataGridPdfExportingOption();
    option.CanExportColumnWidth = true;
    var pdfDoc = new PdfDocument();
    pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
    pdfDoc.Save(stream);
    pdfDoc.Close(true);
    SaveService saveService = new();
    saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream); ;
}
```

## Note

If your image source is an embedded resource, you can fetch the image as shown below:
```
var img = ImageSource.FromResource("DataGridSample.Resources.Images.image0.png", typeof(EmployeeViewModel).GetTypeInfo().Assembly);
```

 ![ExportImageColumn.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyODExIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.DCvq03oC42hjhuOD1nzLPuSaKaIFJqJCyFbIUnUL52w)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-export-a-DataGridImagecolumn-to-pdf-document)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to export a DataGridImagecolumn to pdf document in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!