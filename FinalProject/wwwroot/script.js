//load more

$(document).on("click", ".secondary-button", function () {

    let parent = $("#parent-products");

    let skipCount = $("#parent-products").children().length;

    let productCount = $("#product-count").val();

    console.log('erhger');


    $.ajax({
        /* url: `/product/loadmore?skip=${skipCount}`,*/
        url: "/shop/loadmore",
        type: "Get",
        data: {
            skip: skipCount
        },
        success: function (res) {

            $(parent).append(res);
            skipCount = $("#parent-products").children().length;

            if (skipCount >= productCount) {
                $(".show-more button").addClass("d-none");
            }
        }
    })

});






// Copy menu for mobile
function copyMenu() {
    // Copy inside .dpt-cat to .departments
    var dptCategory = document.querySelector('.dpt-cat')
    var dptPlace = document.querySelector('.departments')
    dptPlace.innerHTML = dptCategory.innerHTML;

    // Copy inside nav to nav
    var mainNav = document.querySelector('.header-nav nav')
    var navPlace = document.querySelector('.off-canvas nav')
    navPlace.innerHTML = mainNav.innerHTML;

    // Copy .header-top .wrapper to .thetop-nav
    var topNav = document.querySelector('.header-top .wrapper')
    var topPlace = document.querySelector('.off-canvas .thetop-nav')
    topPlace.innerHTML = topNav.innerHTML;
}

copyMenu();


// Show mobile menu
const menuButton = document.querySelector('.trigger')
const closeButton = document.querySelector('.t-close')
const addClass = document.querySelector('.site')

menuButton.addEventListener('click', () => {
    addClass.classList.toggle('showmenu')
})

closeButton.addEventListener('click', () => {
    addClass.classList.remove('showmenu')
})

// Show sub-menu on mobile
const submenu = document.querySelectorAll('.has-child .icon-small')
submenu.forEach(menu => menu.addEventListener('click', toggle))

function toggle(e) {
    e.preventDefault()

    submenu.forEach(
        item => item !== this
            ? item.closest('.has-child').classList.remove('expand')
            : null
    )

    if (this.closest('.has-child').classList !== 'expand') {
        this.closest('.has-child').classList.toggle('expand')
    }
}


//slider

const swiper = new Swiper('.swiper', {

    loop: true,
    pagination: {
        el: '.swiper-pagination',
    },
});

//Search Side

const searchButton = document.querySelector('.t-search')
const tClose = document.querySelector('.search-close')
const showClass = document.querySelector('.site')

searchButton.addEventListener('click', function () {
    showClass.classList.toggle('showsearch')
})

tClose.addEventListener('click', function () {
    showClass.classList.remove('showsearch')
})

//show dpt menu
const dptButton = document.querySelector('.dpt-cat .dpt-trigger'),
dptClass = document.querySelector('.site');

dptButton.addEventListener('click', function () {
    dptClass.classList.toggle('showdpt')
})

// Product image slider
let productThumb = new Swiper('.small-image', {
    loop: true,
    spaceBetween: 10,
    slidesPerView: 3,
    freeMode: true,
    watchSlidesProgress: true,
    breakpoints: {
        481: {
            spaceBetween: 32
        }
    }
})

let productBig = new Swiper('.big-image', {
    loop: true,
    autoHeight: true,
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev'
    },
    thumbs: {
        swiper: productThumb
    }
})



// Stock products bar width percentage
/*const stocks = document.querySelector('.stock')

for (let x = 0; x < stocks.length; x++) {
    let stock = stocks[x].dataset.stock
    let available = stocks[x].querySelector('.qty-available').innerHTML
    let sold = stocks[x].querySelector('.qty-sold').innerHTML
    let percent = sold * 100 / stock

    stocks[x].querySelector('.available').style.width = percent + '%'
}
*/

// wishlist

let wishlistBtns = document.querySelectorAll(".ri-heart-fill")

let products = [];

if (localStorage.getItem("products")) {
    products = JSON.parse(localStorage.getItem("products"))
}

document.querySelector(".item-number").innerText = getProductsCount(products);

wishlistBtns.forEach(wishlistBtn => {

    let heartProducts = document.querySelectorAll('.pr-id')
    let productId;
    heartProducts.forEach(prod => {
        if (prod.dataset.id == wishlistBtn.dataset.id) {
            productId = parseInt(wishlistBtn.dataset.id);
        }
    })
    let existProduct = products.find(m=>m.id ==productId);
    if (existProduct&&products.includes(existProduct)) {
        wishlistBtn.classList.add('heart-active')
    }
    wishlistBtn.addEventListener("click", function (e) {
        
        e.preventDefault();
        if (!wishlistBtn.classList.contains("heart-active")) {
        
            wishlistBtn.classList.add("heart-active");
       
            let wishlistProductImage = document.querySelectorAll('.pr-image');
            let wishlistProductName = document.querySelectorAll('.pr-title');
            let wishlistProductPrice = document.querySelectorAll('.pr-disc-price');
            let wishlistProductId = this.getAttribute('data-id');

            let initPhoto;
            let initName;
            let initPrice;

            for (var i = 0; i < wishlistProductImage.length; i++) {
                if (wishlistProductImage[i].dataset.id == wishlistBtn.dataset.id) {
                    initPhoto = wishlistProductImage[i].getAttribute("src");
                }
                if (wishlistProductName[i].dataset.id == wishlistBtn.dataset.id) {
                    initName = wishlistProductName[i].textContent;
                }
                if (wishlistProductPrice[i].dataset.id == wishlistBtn.dataset.id) {
                    initPrice = wishlistProductPrice[i].textContent;
                }

            }
            
       
            let existProduct = products.find(m => m.id == wishlistProductId);
        if (existProduct != undefined) {
            existProduct.count += 0;
        }
        else{
            products.push({
                id: wishlistProductId,
                image: initPhoto,
                name: initName,
                price: initPrice,
                count:1
            })
            document.querySelector(".item-number").innerText = getProductsCount(products);
        }
       

        localStorage.setItem("products", JSON.stringify(products));
        document.querySelector(".item-number").innerText = getProductsCount(products);
        }
        else{
            
            wishlistBtn.classList.remove("heart-active");

            let productId = parseInt(this.dataset.id);

            let existProduct = products.find(m=>m.id ==productId);
             if (existProduct) {
                
                const newProducts=products.filter(m=>m!==existProduct);
                localStorage.setItem('products',JSON.stringify(newProducts));
                 document.querySelector(".item-number").innerText = getProductsCount(newProducts);                 
                 window.location.reload()                
                
            }
            
        }
        

    })
});



function getProductsCount(items) {
    return items.length
}

function getProductsCountForBasket(items) {
    let sum = 0;
    items.forEach(item => {
        sum += item.Count;
    })
    return sum;
}


//basket
let basketProducts = [];
let basketBtns = document.querySelectorAll(".ri-shopping-basket-fill")
console.log(basketBtns)

if (localStorage.getItem("basketProducts") !=null) {
    basketProducts = JSON.parse(localStorage.getItem("basketProducts"))
    
}
if (basketProducts.length != 0) {
    getProductsCountForBasket(basketProducts)
}

document.querySelector(".basketItem-number").innerText = getProductsCountForBasket(basketProducts);

basketBtns.forEach(basketBtn => {
    basketBtn.addEventListener("click", function (e) {
        
        e.preventDefault();

        let basketProductImage = document.querySelectorAll('.pr-image');
        let basketProductName = document.querySelectorAll('.pr-title');
        let basketProductPrice = document.querySelectorAll('.pr-disc-price');
        let basketProductId = this.getAttribute('data-id');

        let initPhoto;
        let initName;
        let initPrice;

        for (var i = 0; i < basketProductImage.length; i++) {
            if (basketProductImage[i].dataset.id == basketBtn.dataset.id) {
                initPhoto = basketProductImage[i].getAttribute("src");
            }
            if (basketProductName[i].dataset.id == basketBtn.dataset.id) {
                initName = basketProductName[i].textContent;
            }
            if (basketProductPrice[i].dataset.id == basketBtn.dataset.id) {
                initPrice = basketProductPrice[i].textContent;
            }

        }

        let existBasketProduct = basketProducts.find(m => m.Id == basketProductId);

        if (existBasketProduct)
        {
            existBasketProduct.Count += 1;
        }
        else
        {
            basketProducts.push({
                Id: basketProductId,
                Image: initPhoto,
                Name: initName,
                Price: initPrice.substring(1, initPrice.length),
                Count: 1
            })
        }

        localStorage.setItem("basketProducts", JSON.stringify(basketProducts));

        document.querySelector(".basketItem-number").innerText = getProductsCountForBasket(basketProducts);

    })
});

