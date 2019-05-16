function ValidateForm() {
    let usr = document.forms["formlogin"]["username"].value;
    let pass = document.forms["formlogin"]["password"].value;
    if (usr == "") {
        document.getElementById("error-username").innerText = "Bạn phải nhập tên đăng nhập";
    }
    else {
        document.getElementById("error-username").innerText = "";
    }
    if (pass == "") {
        document.getElementById("error-pass").innerText = "Bạn phải nhập mật khẩu";
    }
    else {
        document.getElementById("error-pass").innerText = "";
    }
    return false;
}
function ShowRegister() {
    document.getElementById("register").style.visibility = "visible";
}
function HideRegister() {
    document.getElementById("register").style.visibility = "hidden";
}