
if (localStorage.getItem("products") !=null) {
    products = JSON.parse(localStorage.getItem("products"))
}

let tableBody = document.querySelector(".table .table-body")

function GetWishProducts(products) {
    tableBody.innerHTML = "";
    for (const product of products) {
        tableBody.innerHTML += `
<tr>
    <td data-id="${product.id}" class="flexitem">
        <div class="thumbnail object-cover">
            <a href="#">
                <img src="${product.image}" alt="">
            </a>
        </div>
        <div class="content">
            <strong><a href="#">${product.name}</a></strong>
          
        </div>
    </td>
    <td>${product.price}</td>
   
    
    <td>
        <div class="delete-icon">
            <a href="#"><i data-id=${product.id} class="ri-delete-bin-line delete-btn"></i></a>
        </div>
    </td>
</tr>`
    }
    let deleteBtns = document.querySelectorAll(".delete-btn");
    if (deleteBtns) {
        deleteBtns.forEach(btn => {
            btn.addEventListener("click", function (e) {
                debugger
                e.preventDefault();

                let id = parseInt(this.dataset.id);

                let dbProducts = products.filter(m => m.id != id);
                localStorage.setItem("products", JSON.stringify(dbProducts));


                GetWishProducts(dbProducts)

                document.querySelector(".item-number").innerText = getProductsCount(products);
                window.location.reload()
            })
        })
    }
}

GetWishProducts(products)





document.querySelector(".item-number").innerText = getProductsCount(products);

function getProductsCount(items) {
    let resultCount = 0;
    for (const item of items) {
        resultCount += item.count
    }
    return resultCount;
}




