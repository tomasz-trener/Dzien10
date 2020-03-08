<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicySerwis.aspx.cs" Inherits="P07AplikacjaZawodnicy.ZawodnicySerwis" %>

<table class="table">
    <thead class=" text-primary">
        <th>Imie
        </th>
        <th>Nazwisko
        </th>
        <th>Kraj
        </th>
        <th class="text-right">Wzrost
        </th>
    </thead>
    <tbody>

        <%
            for (int i = 0; i < zawodnicy.Length; i++)
            {  %>

                <tr>
                    <td><%= zawodnicy[i].imie %>
                    </td>
                    <td><%= zawodnicy[i].nazwisko %>
                    </td>
                    <td><%= zawodnicy[i].kraj %>
                    </td>
                    <td class="text-right"><%= zawodnicy[i].wzrost %>
                    </td>
                </tr>

        <% }
        %>
    </tbody>
</table>
