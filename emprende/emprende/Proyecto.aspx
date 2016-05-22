<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Proyecto.aspx.cs" Inherits="emprende.Proyecto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container con">
      <div class="col-md-8 col-md-offset-2">        
        <div class="page-header">
            <h2>Publicar proyecto</h2>
        </div>
        <div class="form-horizontal ">
            <div class="form-group">
               <div class="col-md-9">
                 <label>Título Proyecto</label>
                 <asp:TextBox runat="server" class="form-control" ID="txttitulo" />
               </div>            
            </div>
          <div class="form-group">
              <div class="col-md-9">
              <label>Descripción</label>
              <textarea runat="server" id="txtdescripcion" class="form-control" cols="20" rows="3"></textarea>
              </div>  
          </div>
           
           <div class="form-group">
             <div class="col-md-7">  
               <label>Seleccione un archivo</label>    
               <asp:FileUpload ID="FileUpload1"  ToolTip="Subir Archivo" runat="server" /> 
            </div>
            </div>

           <div class="form-group">
             <div class="col-md-7">    
             <label>Categoría</label>
               <asp:Panel runat="server" ScrollBars="Vertical" Height="150px">
                  <asp:GridView ID="Grid" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped table-hover table-responsive" DataKeyNames="idcategoria" >
                                 <Columns>
                                     <asp:BoundField DataField="descripcion" HeaderText="Descripción">
                                     <ItemStyle Width="100px" />
                                     </asp:BoundField>
                                     <asp:TemplateField HeaderText="Seleccione">
                                         <ItemTemplate>
                                             <asp:CheckBox ID="CheckBox1" runat="server" />
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                             </asp:GridView>
                 </asp:Panel>
               
              </div>  
             </div>   
             
            <br/>

            <div class="form-group">
                <div class="col-md-9">
                    <asp:Button Text="Enviar" runat="server"  CssClass=" btn btn-primary pull-right " ID="btnenviar" OnClick="btnenviar_Click" />         
                </div>          
            </div>

          </div>

        </div>





       </div> <%--fin col--%> 


    </div>




</asp:Content>
