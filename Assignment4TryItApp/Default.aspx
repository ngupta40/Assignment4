<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment4TryItApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <asp:Table ID="SvcTable" runat="server" GridLines="Both" Height="175px" Caption="Services Table" 
            Font-Names="Arial"
            BackColor="White"
            BorderColor="Black"
            BorderWidth="2"
            ForeColor="White"
            CellPadding="5"
            CellSpacing="5">
        <asp:TableHeaderRow runat="server" Font-Bold="true" BackColor="Black">
                <asp:TableHeaderCell>Service Name</asp:TableHeaderCell>
                <asp:TableHeaderCell Width ="200" HorizontalAlign ="Center">Service Description</asp:TableHeaderCell>
                <asp:TableHeaderCell Width ="50">Operation Name</asp:TableHeaderCell>
                <asp:TableHeaderCell Width ="50">Service Link</asp:TableHeaderCell>
                <asp:TableHeaderCell Width ="50">Service Testing</asp:TableHeaderCell>
                
        </asp:TableHeaderRow>
        <asp:TableRow ID="TableRow1" runat="server" BackColor="Blue">
                <asp:TableCell>Verification</asp:TableCell>
                <asp:TableCell Width =" 200">This service takes an input xml url as a string and xsd url as a string and validates the XML file against the corresponding (XSD) file return Status/Error</asp:TableCell>
                <asp:TableCell Width =" 200">Method Name : verification , Argument 1 Type : url string , Argument 2 Type : url string , Return Type : String</asp:TableCell>
                <asp:TableCell Width =" 200">http://webstrar29.fulton.asu.edu/Page1/Service1.svc?wsdl</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow3" runat="server" BackColor="Blue">
                <asp:TableCell>Search</asp:TableCell>
                <asp:TableCell Width =" 200">This service takes an input xml url as a string and a key name as a string returns string for the content value</asp:TableCell>       
                <asp:TableCell Width =" 200">Method Name : search , Argument 1 Type : url string , Argument 2 Type :string Return Type : string</asp:TableCell>
                <asp:TableCell Width =" 200">http://webstrar29.fulton.asu.edu/Page1/Service1.svc?wsdl</asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>
