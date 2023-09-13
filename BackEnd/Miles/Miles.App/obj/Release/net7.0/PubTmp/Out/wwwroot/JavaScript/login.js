const eyeBtn = document.querySelector("#passwordShow");
eyeBtn.addEventListener("click", () => {
    showPassword();
})
function showPassword() {
    var x = document.querySelector("#passwordInput input");
    if (x.type === "password") {
        x.type = "text";
        eyeBtn.className = "fa fa-eye-slash"
    } else {
        x.type = "password";
        eyeBtn.className="fa fa-eye"
    }
}