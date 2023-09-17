	const input = document.querySelector("#brandInput");
	const modelInput = document.querySelector("#modelInput");
	const yearInput = document.querySelector(".yearInput")
	const modelInputNone = document.querySelector(".modelInputNone")
    const sliders = document.querySelectorAll(".sliderMain");
	let dateDropdown = document.getElementById('date-dropdown');
	let currentYear = new Date().getFullYear();
	let earliestYear = 2000;
	let brand = null;
let href = `/car/GetAllModel`;
	fetch(href)
		.then(x => x.json())
		.then(x => {
			const elements = x;
	for (let i = 0; i < elements.length; i++) {
				if (elements[i].id == modelInputNone.value){
		brand = elements[i].brandId;
					input.querySelectorAll("option").forEach(x => {
						if(x.value == brand){
		x.selected = true;
						}
					})
			
				}
	if (elements[i].brandId == input.value) {
					var opt = document.createElement('option');
	opt.value = elements[i].id;
	opt.innerHTML = elements[i].name;
	if (elements[i].id == modelInputNone.value) {
		opt.selected = true;
					}
	modelInput.appendChild(opt);
				}
			}
			input.addEventListener("change", () => {
		modelInput.innerHTML = ""
				for (let i = 0; i < elements.length; i++) {
					if (elements[i].brandId == input.value) {
						var opt = document.createElement('option');
	opt.value = elements[i].id;
	opt.innerHTML = elements[i].name;
	modelInput.appendChild(opt);
					}
				}
			})
		})
	while (currentYear >= earliestYear) {

		let dateOption = document.createElement('option');
	if (yearInput.value == currentYear) {
		dateOption.selected = true;
		}
	dateOption.text = currentYear;
	dateOption.value = currentYear;
	dateDropdown.add(dateOption);
	currentYear -= 1;
	}
sliders.forEach(slider => {
	if (slider.parentElement.parentElement.classList.contains("activ")) {
		slider.style.setProperty('--boxAfterBackColor', '#3a4b39');
	slider.style.setProperty('--boxAfterTranslate', 'translateX(1.9em)');
	slider.style.setProperty('--boxAfterButtonColor', '#84da89');
		}
		
		slider.addEventListener("click", () => {
		sliders.forEach(x => {
			x.style.setProperty('--boxAfterBackColor', '#313033');
			x.style.setProperty('--boxAfterTranslate', 'translateX(0)');
			x.style.setProperty('--boxAfterButtonColor', '#aeaaae');
		})
			slider.style.setProperty('--boxAfterBackColor', '#3a4b39');
	slider.style.setProperty('--boxAfterTranslate', 'translateX(1.9em)');
	slider.style.setProperty('--boxAfterButtonColor', '#84da89');

		})
	})
	const setasmains = document.querySelectorAll(".setasmain");
	setasmains.forEach(set => {
		set.addEventListener("click", (e) => {
			e.preventDefault();
			const endpoint = set.getAttribute("href");
			fetch(endpoint)
				.then(x => x.json())
				.then(x => {
					if (x.status == 200) {
						Swal.fire(
							'Good job!',
							'Successfully change main photo!',
							'success'
						)
					}
					else if (x.status == 404) {
						Swal.fire({
							icon: 'error',
							title: 'Oops...',
							text: 'Something went wrong!',
							footer: '<a href="">Why do I have this issue?</a>'
						})
					}
				})
		})
	})
	const removeImages = document.querySelectorAll(".removeimage");
	removeImages.forEach(img => {
		img.addEventListener("click", (e) => {
			e.preventDefault();
			const endpoint = img.getAttribute("href");
			fetch(endpoint)
				.then(x => x.json())
				.then(x => {
					if (x.status == 200) {
						Swal.fire(
							'Good job!',
							'Successfully Remove',
							'success'
						)
						let parent = img.parentElement.parentElement;
						parent.remove();
					}
					else if (x.status == 404) {
						Swal.fire({
							icon: 'error',
							title: 'Oops...',
							text: `${x.desc}`,
						})
					}
					else if (x.status == 400) {
						Swal.fire({
							icon: 'error',
							title: 'Oops...',
							text: `${x.desc}`,
						})
					}
				})
		})
	})
//const currentDate = new Date();
//currentDate.setHours(currentDate.getHours() + 4);
//const year = currentDate.getFullYear();
//const month = String(currentDate.getMonth() + 1).padStart(2, '0');
//const day = String(currentDate.getDate()).padStart(2, '0');
//const hours = String(currentDate.getHours()).padStart(2, '0');
//const minutes = String(currentDate.getMinutes()).padStart(2, '0');

//const formattedDate = `${year}-${month}-${day}T${hours}:${minutes}`;
//document.querySelector(".auctionDate").min = formattedDate; 