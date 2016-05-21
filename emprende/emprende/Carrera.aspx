<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Carrera.aspx.cs" Inherits="emprende.Carrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container">
      <div class="col-md-8 col-md-offset-2 ">
        <div class="page-header">
            <h2>Mantenimiento Carrera</h2>
        </div>
     <div class="form-horizontal">

         <div class="form-group">
            <div class="col-md-3">
              <label>ID</label>
              <asp:TextBox runat="server" CssClass="form-control" ID="txtid" ReadOnly="true" />
            </div>
         </div>
         <div class="form-group">
             <div class="col-md-8">
                 <label>Descripción</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtdescripcion" />
             </div>   
         </div>

          <div class="form-group">
             <div class="col-md-6">
                 <label>Buscar</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtbuscar" />
             </div>   
          </div>
         <asp:Panel runat="server" ID="panel" BorderWidth="1px" CssClass=" " Height="200px" ScrollBars="Vertical" >     
          <div class="form-group">
               <asp:GridView ID="Grid" runat="server"></asp:GridView>
           </div> 
         </asp:Panel>
         <br/>

         <div class="form-group">
            <div class="col-md-12">
             <asp:LinkButton runat="server" ID="btnnuevo" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-plus" ></span> Nuevo</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btngrabar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-floppy-disk" ></span> Grabar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btncancelar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-ban-circle" ></span> Cancelar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btnmodificar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-refresh" ></span> Modificar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btneliminar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-trash" ></span> Eliminar</asp:LinkButton>
            </div>  
         </div>




      </div> <%--fin form-horizontal--%>


     </div>   




    </div> 







</asp:Content>
