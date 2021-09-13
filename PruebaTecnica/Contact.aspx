<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PruebaTecnica.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
<div class="container">

        <div class="row">
            
                 <div class="form-group">
                  <label for="inputPassword4">Numero de documento</label>
                    <asp:TextBox ID="txtnumdoc" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:Button ID="btnconsutar" runat="server" Text="Consultar" CssClass="btn btn-primary" OnClick="btnconsutar_Click" />
                </div>
            <br />
            <br />
                <div class="form-group">
                  <label for="inputEmail4">Tipo de Documento</label>
                    <asp:TextBox ID="txttipodoc" runat="server" CssClass="form-control"  Enabled="False"></asp:TextBox>
                </div>               
            
                <div class="form-group">
                  <label for="inputPassword4">Nombre y apellido</label>
                    <asp:TextBox ID="txtnombres" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Contrato Laboral</label>
                    <asp:TextBox ID="txtcontrato" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Cargo</label>
                    <asp:TextBox ID="txtcargo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Riesgo Laboral(ARL)</label>
                    <asp:TextBox ID="txtriesgo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Fecha de inicio contrato</label>
                    <asp:TextBox ID="txtfechainicio" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>                    

                </div>
                <div class="form-group">
                  <label for="inputPassword4">Fecha final de contrato (Proyectada si se tiene)</label>
                    <asp:TextBox ID="txtfechafinal" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Salario</label>
                    <asp:TextBox ID="txtsalario" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>

            <div class="alert alert-info">
                <div class="form-group">
                  <label for="inputPassword4">Periodo laborado</label>
                    <asp:TextBox ID="txtperiodolaborado" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Horas Total Laboradas</label>
                    <asp:TextBox ID="txthoralaborada" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Horas diurnas</label>
                    <asp:TextBox ID="txtdiurnas" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Horas Nocturnas</label>
                    <asp:TextBox ID="txtNocturnas" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Horas dominicales</label>
                    <asp:TextBox ID="txtdominicales" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Horas festivas</label>
                    <asp:TextBox ID="txtfestivas" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                  <label for="inputPassword4">Descuentos de nomina</label>
                    <asp:TextBox ID="txtdescuentos" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="alert alert-danger" runat="server" id="idmostrarmsg" visible="false" >

            </div>
                 
      </div>
    <asp:Button ID="btnGuardarData" runat="server" Text="Guardar Información" CssClass="btn btn-danger" OnClick="btnGuardarData_Click"  />
    <asp:Button ID="btnNewSearch" runat="server" Text="Nueva Consulta" CssClass="btn btn-warning" OnClick="btnNewSearch_Click"  />
    
</div> 
</asp:Content>
