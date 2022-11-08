<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication5._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <%--<h2>
        Welcome to ASP.NET!
    </h2>--%>
    
    <asp:Button ID="Button1" runat="server" Text="Add Category" 
        onclick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Add Product" 
        onclick="Button2_Click" />
    <asp:Button ID="Button13" runat="server" onclick="Button13_Click" 
        Text="View Categories" />
    <asp:Button ID="Button3" runat="server" Text="View Products" 
        onclick="Button3_Click2" style="height: 26px" />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="266px">
        <asp:Label ID="Label1" runat="server" Text="Select Category Type :"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Parent</asp:ListItem>
            <asp:ListItem>Child</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button4" runat="server" Height="26px" Text="-&gt;" 
            onclick="Button4_Click" />
        <br />
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="73px">
            <asp:Label ID="Label2" runat="server" Text="Category Name :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Height="26px" Text="Add" 
                onclick="Button5_Click" />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="120px">
            <asp:Label ID="Label3" runat="server" Text="Select "></asp:Label>
            &nbsp;Parent Category :<asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Category Name :"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Height="26px" Text="Add" 
                onclick="Button6_Click" />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        <%--Category Name :--%>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server" Height="255px">
        <asp:Label ID="Label5" runat="server" Text="Select Category Type :"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>Parent</asp:ListItem>
            <asp:ListItem>Child</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button10" runat="server" onclick="Button10_Click" 
            Text="-&gt;" />
        <br />
        <br />
        <asp:Panel ID="Panel5" runat="server" Height="155px">
            <asp:Label ID="Label6" runat="server" Text="Select Parent Category :"></asp:Label>
            <asp:DropDownList ID="DropDownList4" runat="server" 
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
            </asp:DropDownList>
            &nbsp;&nbsp;<asp:Button ID="Button15" runat="server" onclick="Button15_Click" 
                Text="-&gt;" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Select Child Category :"></asp:Label>
            <asp:DropDownList ID="DropDownList5" runat="server" 
                onselectedindexchanged="DropDownList5_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Product Price"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Width="128px" 
                ontextchanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button16" runat="server" onclick="Button16_Click" 
                Text="Add Product" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Select Product"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList7" runat="server" 
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel6" runat="server" Height="192px">
        <asp:Label ID="Label9" runat="server" Text="Select  Category :"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList6" runat="server" 
            onselectedindexchanged="DropDownList4_SelectedIndexChanged" 
            style="height: 22px">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" onclick="Button12_Click" Text="View" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel7" runat="server" Height="172px">
        <asp:Label ID="Label12" runat="server" Text="Select  Category :"></asp:Label>
        <asp:DropDownList ID="DropDownList8" runat="server" 
            onselectedindexchanged="DropDownList4_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="Button14" runat="server" onclick="Button14_Click" 
            Text="Show Products" />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </asp:Panel>
    <br />
    <br />
    <br />
    
</asp:Content>
