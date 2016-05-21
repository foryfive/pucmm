<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Carrera.aspx.cs" Inherits="emprende.Carrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container">
      <div class="col-md-10 col-md-offset-1 ">
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

          <div runat="server" id="divbuscar" class="form-group">
             <div class="col-md-6">
                 <label>Buscar</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtbuscar" OnTextChanged="txtbuscar_TextChanged" />
             </div>   
          </div>
         <br/>
         <asp:Panel runat="server" ID="panel" class="panel"  Height="180px" ScrollBars="Vertical" >     
               <asp:GridView ID="Grid" CssClass="table table-bordered table-striped table-hover table-responsive" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="Grid_SelectedIndexChanged">
                   <Columns>
                       <asp:CommandField ShowSelectButton="True" HeaderText="Seleccionar">
                       <HeaderStyle Width="100px" />
                       </asp:CommandField>
                       <asp:BoundField DataField="idcarrera" HeaderText="ID">
                       <ItemStyle Width="100px" />
                       </asp:BoundField>
                       <asp:BoundField DataField="descripcion" HeaderText="Descripción">
                       <HeaderStyle Width="230px" />
                       </asp:BoundField>
                   </Columns>
               </asp:GridView>

         </asp:Panel>
         <br/>

         <div class="form-group">
            <div class="col-md-12">
             <asp:LinkButton runat="server" ID="btnnuevo" CssClass="btn btn-primary" OnClick="btnnuevo_Click" ><span class="glyphicon glyphicon-plus" ></span> Nuevo</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btngrabar" CssClass="btn btn-primary" OnClick="btngrabar_Click" ><span class="glyphicon glyphicon-floppy-disk" ></span> Grabar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btncancelar" CssClass="btn btn-primary" OnClick="btncancelar_Click" ><span class="glyphicon glyphicon-ban-circle" ></span> Cancelar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btnmodificar" CssClass="btn btn-primary" OnClick="btnmodificar_Click" ><span class="glyphicon glyphicon-refresh" ></span> Modificar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btneliminar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-trash" ></span> Eliminar</asp:LinkButton>
            </div>  
         </div>




      </div> <%--fin form-horizontal--%>


     </div>   




    </div> 







</asp:Content>
