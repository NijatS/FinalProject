﻿const searchInput = document.querySelector(".blog-search-field");
const container = document.querySelector(".searchValue");
if (searchInput.value == "") {
    container.style.display = "none";
}
searchInput.addEventListener("input", (e) => {
    e.preventDefault();
    if (searchInput.value == "") {
        container.style.display = "none";
        return;
    }
    let href = `/shop/search?search=${searchInput.value}`;
    fetch(href)
        .then(x => x.json())
        .then(x => {
            container.innerHTML = ""
            if (x.length !=0){
              container.style.display = "block";
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
                    container.innerHTML += view;
            })
        })
})