<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="knowledge.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="Blood_Bank.Pages.knowledge" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <table border="1" style="text-align:center; font-size:large" class="knowledge" >
        <tr style="font-size:larger">
            <th>
                <b>Blood Groups</b>
            </th>
            <th>
                <b>Gives to these groups</b>
            </th>
            <th>
                <b>Receives from these groups</b>
            </th>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>O-</b>
            </td>
            <td>
                All
            </td>
            <td>
                O- only.
            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>O+</b>
            </td>
            <td>
                AB+,A+,B+,O+
            </td>
            <td>

                O- and O+

            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>A-</b>
            </td>
            <td>
                AB-,AB+,A+,A-
            </td>
            <td>
                O- and A-
            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>A+</b>
            </td>
            <td>
                AB+ and A+
            </td>
            <td>
                O-,O+,A-,A+
            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>B-</b>
            </td>
            <td>

                B-,B+,AB-,AB+</td>
            <td>
                O- and B-
            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>B+</b>
            </td>
            <td>

                B+ and AB+</td>
            <td>
                O-,O+,B-,B+
            </td>
        </tr>
        <tr>
            <td style="color:#ff0000;">
                <b>AB-</b>
            </td>
            <td>

                AB- and AB+</td>
            <td>
                O-,A-,B-,AB-
            </td>
        </tr>
         <tr>
            <td style="color:#ff0000;">
                <b>AB+</b>
            </td>
            <td>

                AB+ only</td>
            <td>
                All
            </td>
        </tr>
    </table>

        <br />
        <br />
        <br />

        <table border="1" style="text-align:center; font-size:large" class="knowledge" >
        <tr style="font-size:larger">
            <th>
                <b>Parent 1</b>
            </th>
            <th>
                <b>Parent 2</b>
            </th>
            <th>
                <b>Baby's possible blood types</b>
            </th>
        </tr>
        <tr>
            <td >
                A
            </td>
            <td>
                A
            </td>
            <td>
                A,O
            </td>
        </tr>
        <tr>
            <td>
                 A
            </td>
            <td>
                B
            </td>
            <td>
              A,B,AB,O
            </td>
        </tr>
        <tr>
            <td>
                A
            </td>
            <td>
                AB
            </td>
            <td>
                A,B,AB
            </td>
        </tr>
        <tr>
            <td>
                A
            </td>
            <td>
                O
            </td>
            <td>
                A,O
            </td>
        </tr>
        <tr>
            <td>
                B
            </td>
            <td>
                B
             </td>
            <td>
                B,O
            </td>
        </tr>
        <tr>
            <td>
                B
            </td>
            <td>
                AB
            </td>
            <td>
                A,B,AB
            </td>
        </tr>
        <tr>
            <td>
                B
            </td>
            <td>
                O
             </td>
            <td>
                B,O
            </td>
        </tr>
         <tr>
            <td>
                AB
            </td>
            <td>
                AB
             </td>
            <td>
                A,B,AB
            </td>
        </tr>
        <tr>
            <td>
                AB
            </td>
            <td>
                O
             </td>
            <td>
                A,B
            </td>
        </tr>
        <tr>
            <td>
                O
            </td>
            <td>
                O
             </td>
            <td>
                O
            </td>
        </tr>
        
       

    </table>
        <br /><br />
        <h2>Misconceptions about donating blood</h2>
        <p style="text-align:left"><b>“I will feel drained and tired after donating “ </b><br /><font style="color:#000000">–You will not feel drained or tired if you continue to drink fluids and have a good meal.</font><br /><br />
<b>“I cannot resume normal activities”</b><br /><font style="color:#000000">-You can resume all your normal activities , though you’re asked to refrain.</font><br /><br />
<b>“I will have low blood”</b><br /><font style="color:#000000">-If you are okayed to donate by the doctor you will still have surplus blood after the donation.</font><br /><br />
<b>“I can’t take alcohol ..”</b><br /><font style="color:#000000">-You can on the next day.</font><br /><br />
<b>“It will be painful while donating”</b><br /><font style="color:#000000">-No, you will not feel any pain.</font><br /><br />
<b>“I will feel dizzy and may faint”</b><br /><font style="color:#000000">-You will not faint or feel uncomfortable after donation blood .</font><br /><br />
<b>“I may get AIDS!”</b><br /><font style="color:#000000">-No! Make sure disposable syringes are used and all measures are taken to keep you germ free.</font><br /><br />
<b>“My blood is common. I don’t think there will be demand for it”</b><br /><font style="color:#000000">-That is why the demand for your type is greater than for rare types.</font><br /><br />
</p>
    </center>
</asp:Content>