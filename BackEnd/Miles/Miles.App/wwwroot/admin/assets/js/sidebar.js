document.querySelectorAll(".nav-link").forEach(item => {
    item.addEventListener("click", () => {
        document.querySelectorAll(".nav-link").forEach(item1 => {
            item1.classList.add("collapsed")
            item1.parentElement.classList.remove("active")
        });
        item.classList.remove("collapsed")
        item.parentElement.classList.add("active")

    })
})
