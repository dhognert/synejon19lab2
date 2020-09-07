<%@ Page Title="AdventureWorks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdventureWorks.aspx.cs" Inherits="synejon19lab2.AdventureWorks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <h3>CRUD the AdventureWorks database!</h3>

<asp:Label ID="Label1" runat="server" />

        Here you can administer the stuff<br />

        <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover"
            AutoGenerateColumns="False" DataKeyNames="DataBaseLogId" EmptyDataText="There are no data records to display."
            PageSize="10" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" 
            PagerSettings-Position="TopAndBottom" PagerSettings-Mode="NumericFirstLast"
            OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting"
            OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowUpdating="GridView1_RowUpdating">
             <Columns>
                <asp:BoundField DataField="PostTime" HeaderText="Post time" SortExpression="PostTime" HeaderStyle-CssClass="visible-xl" ItemStyle-CssClass="visible-xl" />
                <asp:BoundField DataField="Event" HeaderText="Event" SortExpression="Event" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" />
             </Columns>
        </asp:GridView>

</asp:Content>
