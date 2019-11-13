function saveMessage(Nombre) {
    //alert("El residente: " + Nombre + ", se ha guardado correctamente");

    document.getElementById("divServerValidations").innerText = Nombre + ", se ha guardado correctamente";

}

function setFocusOnElement(element) {
    element.focus();
}
