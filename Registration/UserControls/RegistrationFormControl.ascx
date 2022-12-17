<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegistrationFormControl.ascx.cs" Inherits="Registration.UserControls.RegistrationFormControl" %>


<style>
    wd{
        width: 100px;
    }
    table 
    {
        min-width: 453px;
        margin: auto;
    }
</style>

<table>
    <tr>
        <td class="wd">
            <lable id="lblName" for="txtName" runat="server" >Name</lable>
        </td>
        <td>
            <input type="text" disabled id="txtName" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="wd">
            <lable id="lblEmail" for="txtEmail" runat="server" >Email</lable>
        </td>
        <td>
            <input type="text" disabled id="txtEmail" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="wd">
            <lable id="lblDob" for="txtDob" runat="server" >Data Of Birth</lable>
        </td>
        <td>
            <input type="text" disabled id="txtDob" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="wd">
            <lable id="lblCountry" for="txtCountry" runat="server" >Country</lable>
        </td>
        <td>
            <input type="text" disabled id="txtCountry" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="wd">
            <lable id="lblGender" for="txtGender" runat="server" >Gender</lable>
        </td>
        <td>
            <input type="text" disabled id="txtGender" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="wd">
            <lable id="lblMeal" for="txtMeal" runat="server" >Meal</lable>
        </td>
        <td>
            <input type="text" disabled id="txtMeal" runat="server" />
        </td>
    </tr>
</table>
