const searchInputs = document.querySelector(".blog-search-field");
const containers = document.querySelector(".searchValue");
if (searchInputs.value == "") {
    containers.style.display = "none";
}
searchInputs.addEventListener("input", (e) => {
    e.preventDefault();
    if (searchInputs.value == "") {
        containers.style.display = "none";
        return;
    }
    search();
})
function search() {
    let href = `/shop/search?search=${searchInputs.value}`;
    fetch(href)
        .then(x => x.json())
        .then(x => {
            containers.innerHTML = ""
            if (x.length != 0) {
                containers.style.display = "block";
            }
            x.forEach(item => {
                let price = item.price.toLocaleString('en-US');
                let image = null;
                for (let i = 0; i < item.carImages.length; i++) {
                    if (item.carImages[i].isMain) {
                        image = item.carImages[i].image;
                    }
                }
                let view = `<div class="searchItem">
                                                    <img src="/Images/Cars/${image}"/>
                                                    <a href="/shop/detail/${item.id}">
                                                        <h4>${item.model.name} ${item.fabricationYear}</h4>
                                                         <p>${price} </p>
                                                    </a>
                                 </div>`;
                containers.innerHTML += view;
            })
        })
}