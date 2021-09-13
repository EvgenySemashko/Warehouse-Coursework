const dropdownMenuButton = document.querySelector('.header-dropdown_menu');
if(dropdownMenuButton){
    const dropdownMenu = document.querySelector('.dropdown-menu');
    dropdownMenuButton.addEventListener("click", function(e) {
        dropdownMenu.classList.toggle('_active');
    });
}