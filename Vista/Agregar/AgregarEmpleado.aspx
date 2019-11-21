<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="AgregarEmpleado.aspx.cs" Inherits="TechRestaurant.AgregarEmpleado" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar empleado</title>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">
    <div class ="col-4 offset-4">
        <div class="card">
            <div class="card-header bg-info text-white" style="text-align:center">AGREGAR EMPLEADO</div>
    
            <div class="card-body">

                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txId">Cédula o identificación</label>
                    </div>     
                    <div class ="col-12">                                         
                        <asp:TextBox type="text" id="txId" class="form-control" placeholder="Ingrese un número de identificación" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txNombre">Nombre</label>
                    </div>     
                    <div class ="col-12">                                         
                        <asp:TextBox type="text" id="txNombre" class="form-control" placeholder="Ingrese el nombre del empleado" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txApellido">Apellido</label>
                    </div>     
                    <div class ="col-12">                                         
                        <asp:TextBox type="text" id="txApellido" class="form-control" placeholder="Ingrese el apellido del empleado" runat="server"></asp:TextBox>
                    </div>
                </div>                            
    
                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txCorreo">Correo electrónico</label>
                    </div>     
                    <div class ="col-12">                                         
                        <asp:TextBox type="email" id="txCorreo" class="form-control" placeholder="Ingrese la dirección de correo electrónico" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txCargo">Cargo</label>
                    </div>     
                    <div class ="col-12">
                        <asp:TextBox type="text" id="txCargo" class="form-control" placeholder="Ingrese el cargo del empleado" runat="server"></asp:TextBox>
                    </div>
                </div>
    
                <div class="form-group" style="margin-bottom:10px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txContrasena">Contraseña</label>
                    </div>     
                    <div class ="col-12">
                        <asp:TextBox type="password" id="txContrasena" class="form-control" placeholder="Ingrese la contraseña del empleado" runat="server"></asp:TextBox>
                    </div>             
                </div>

                <div class="form-group" style="margin-bottom:40px; margin-top:15px">
                    <div class ="col-12">
                        <label for="txConfirmar">Confirmar contraseña</label>
                    </div>     
                    <div class ="col-12">
                        <asp:TextBox type="password" id="txConfirmar" class="form-control" placeholder="Ingrese de nuevo la contraseña" runat="server"></asp:TextBox>
                    </div>             
                </div>
    
                <div class="form-group">
                    <div class ="col-12">
                        <asp:Button type="submit" id="btAgregar" class="btn btn-info btn-lg btn-block" runat="server" OnClick="btAgregar_Click" Text="Agregar" />
                    </div>               
                </div>
    
                <div class="row" style="margin-top:20px">
                    <div class ="col-12">
                        <asp:Label ID="lbMensaje" runat="server" ForeColor="Green" Text=""></asp:Label>
                    </div>
                </div>

                <div class="row" style="margin-top:20px">
                    <div class ="col-12">
                        <asp:Label ID="lbError" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>

<div class="form-group">
    <div class="col-11 offset-1">
        <asp:CompareValidator ID="cvContra" runat="server" ErrorMessage="* Las contraseñas no coinciden" ForeColor="Red" ControlToValidate="txContrasena" ControlToCompare="txConfirmar"></asp:CompareValidator>
    </div>
</div>

</asp:Content>

<asp:Content ContentPlaceHolderID="scripts" runat="server">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</asp:Content>
