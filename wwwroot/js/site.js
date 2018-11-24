let btn = document.querySelector(".update");
let divEle = document.querySelector(".todo");

btn.addEventListener("click", (e) => {
  e.preventDefault();

  let url = "/Home/UpdateTodoList?done=true";
  divEle.innerHTML = "Update...";
  btn.disabled = true;

  var xhr = new XMLHttpRequest();
  xhr.open("GET", url, true);

  xhr.addEventListener("load", () => {
    if (xhr.status === 200) {
      divEle.innerHTML = xhr.responseText;
      console.log(xhr.responseText);
      btn.disabled = false;
    }
  });

  setTimeout(() => xhr.send(), 1500);

});
