

if (localStorage.getItem("basketProducts") != null) {
    var currentBasketProducts = JSON.parse(localStorage.getItem("basketProducts"))
}

let basketTableBody = document.querySelector(".basket-table")
const totalPrice = document.querySelector('.total-price')
function GetBasketProducts(products) {
    basketTableBody.innerHTML = "";
    for (const basketProduct of products) {

        basketTableBody.innerHTML += `
    <tr>
        <td  class="flexitem basket-product-item">
            <div class="thumbnail object-cover">
                <a href="#">
                    <img src="${basketProduct.Image}" alt="">
                </a>
            </div>
            <div class="content">
                <strong><a href="#">${basketProduct.Name}</a></strong>            
            </div>
        </td>
        <td>${basketProduct.Price}</td>
        <td>
            <p>${basketProduct.Count}</p>
        </td>
        <td>$${basketProduct.Price * basketProduct.Count}</td>
        <td>
            <a href="#">
                <i data-id="${basketProduct.Id}" class="ri-close-line basket-delete-btn"></i>
            </a>
        </td>
    </tr>`
    }
    let deleteBasketBtns = document.querySelectorAll(".basket-delete-btn");
    
    if (deleteBasketBtns) {

        deleteBasketBtns.forEach(btn => {
            btn.addEventListener("click", function (e) {
                debugger
                e.preventDefault();                

                let newProducts = products.filter(m => m.Id !== btn.dataset.id);
               
                localStorage.setItem("basketProducts", JSON.stringify(newProducts));

                GetBasketProducts(newProducts)
               
                GetBasketTotalPrice()
                window.location.reload()
            })
        })
    }
}

GetBasketProducts(currentBasketProducts);


document.querySelector(".basketItem-number").innerText = getBasketProductsCount(currentBasketProducts);

function getBasketProductsCount(items) {
    let sum = 0;
    items.forEach(item => {
        sum += item.Count;
    })
    return sum;
}


function GetBasketTotalPrice() {
    
    let sum = 0;
    let total = 0;
    currentBasketProducts.forEach(product => {
        total = Number(product.Count) * Number(product.Price);
        sum += total;
    })
    totalPrice.textContent = `$${sum}`;
}
GetBasketTotalPrice();

