<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tips._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url" DisplayMode="HyperLink" Height="25px" Width="280px">
    <asp:ListItem Value="http://www.microsoft.com">Microsoft</asp:ListItem>
</asp:BulletedList>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/hyperlinks.xml"></asp:XmlDataSource>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
        <asp:ListItem Value="0">BulletedList</asp:ListItem>
        <asp:ListItem Value="1">File Upload</asp:ListItem>
    </asp:RadioButtonList>
    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View1" runat="server">
            <asp:BulletedList ID="BulletedList2" runat="server" DataSourceID="XmlDataSource2" DataTextField="text" DataValueField="url" DisplayMode="HyperLink" Height="25px" OnClick="BulletedList1_Click" Width="280px">
                <asp:ListItem Value="http://www.microsoft.com">Microsoft</asp:ListItem>
            </asp:BulletedList>
            <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/hyperlinks.xml"></asp:XmlDataSource>
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:FileUpload ID="FileUpload2" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Upload" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
        </asp:View>
    </asp:MultiView>
    <hr />

</asp:Content>
