const createFooter = () => {
    let footer = document.querySelector('footer');

    footer.innerHTML = `
    <div class="footer-content">
            <img src="img/light-logo.png" class="logo" alt="">
            <div class="footer-ul-container">
                <ul class="category">
                    <li class="category-title">men</li>
                    <li><a href="#" class="footer-link">t-shirts</a></li>
                    <li><a href="#" class="footer-link">sweatshirts</a></li>
                    <li><a href="#" class="footer-link">shirts</a></li>
                    <li><a href="#" class="footer-link">jeans</a></li>
                    <li><a href="#" class="footer-link">trousers</a></li>
                    <li><a href="#" class="footer-link">shoes</a></li>
                    <li><a href="#" class="footer-link">casuals</a></li>
                    <li><a href="#" class="footer-link">formals</a></li>
                    <li><a href="#" class="footer-link">sports</a></li>
                    <li><a href="#" class="footer-link">wacth</a></li>
                    <li><a href="#" class="footer-link">t-shirts</a></li>
                </ul>
                <ul class="category">
                    <li class="category-title">women</li>
                    <li><a href="#" class="footer-link">t-shirts</a></li>
                    <li><a href="#" class="footer-link">sweatshirts</a></li>
                    <li><a href="#" class="footer-link">shirts</a></li>
                    <li><a href="#" class="footer-link">jeans</a></li>
                    <li><a href="#" class="footer-link">trousers</a></li>
                    <li><a href="#" class="footer-link">shoes</a></li>
                    <li><a href="#" class="footer-link">casuals</a></li>
                    <li><a href="#" class="footer-link">formals</a></li>
                    <li><a href="#" class="footer-link">sports</a></li>
                    <li><a href="#" class="footer-link">wacth</a></li>
                    <li><a href="#" class="footer-link">t-shirts</a></li>
                </ul>
            </div>
        </div>
        <p class="footer-title">about company</p>
        <p class="info">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Corrupti, ratione culpa? Magnam voluptatibus placeat sint optio nobis eos iusto pariatur. Quis impedit cumque exercitationem debitis tempore, fugiat cupiditate quia laudantium a perspiciatis
            deleniti necessitatibus cum quo! Atque fugiat sunt porro dolore aperiam, iste harum neque veniam voluptatibus quibusdam asperiores doloribus laudantium repellat quis, similique odio perspiciatis. Repellat quos libero porro, repudiandae veritatis
            voluptatibus praesentium commodi aperiam aspernatur beatae consequatur eveniet accusantium totam tenetur vel excepturi minima iusto facere voluptatem cupiditate, asperiores aliquam quod, suscipit dolores. Nulla quibusdam itaque sit. Nam laborum
            assumenda delectus veniam rem alias voluptatibus sed voluptatem ipsam!</p>
        <p class="info">support emails - help@clothing.com, customersupport@clothing.com</p>
        <p class="info">telephone - 180 00 00 001, 180 00 00 002</p>
        <div class="footer-social-container">
            <div>
                <a href="#" class="social-link">terms & services</a>
                <a href="#" class="social-link">privacy police</a>
            </div>
            <div>
                <a href="#" class="social-link">Instagram</a>
                <a href="#" class="social-link">Facebook</a>
                <a href="#" class="social-link">twitter</a>
            </div>
        </div>
        <p class="footer-credit">Clothing, Best apparels online store</p>
    `;
}

createFooter();