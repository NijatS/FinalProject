const links = document.querySelectorAll("#menu-item a")
const currentUrl = window.location.pathname;
let controller = currentUrl.split("/")[1]
let action = null;
let id = currentUrl.split("/")[3]
if (controller == "") {
    controller = "home";
}
if (currentUrl.split("/")[2] == null) {
    action = "index";
}
else {
    action = currentUrl.split("/")[2];
}
links.forEach(link => {
    if (link.textContent.toLowerCase().includes(controller.toLowerCase())) {
        link.style.color ="#f4c23d"
    }
})
window.onload = function () {
    var spinner = document.getElementById("spinner");
    var dataContainer = document.getElementsByName("sidebar-menu-container"); // The container where your data will be displayed

    spinner.style.display = "block"; // Show the spinner

    var xhr = new XMLHttpRequest();
    if (id == null) {
        xhr.open("GET", `/${controller}/${action}`, true); // Replace with your actual route
    }
    else {
        xhr.open("GET", `/${controller}/${action}/${id}`, true); // Replace with your actual route
    }
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            // Hide the spinner
            spinner.style.display = "none";

            // Process and display your data
            dataContainer.innerHTML = xhr.responseText; // Modify this line to display your data as needed
        }
    };
    xhr.send();
};