// it checks whether the text box has any task info or not
document.querySelector('#add1').onclick =function(){
  if(document.querySelector('#taskdet input').value.length==0){
  alert("enter your task");
 }


//  if it contains text the new div element is created data is stored and delete button is created 
 else{
    document.querySelector('#tasks').innerHTML +=`
      <div class="task">
      <input type="checkbox" id="check">
            ${document.querySelector('#taskdet input').value}
          </span>  
            <button class='del'>Delete</button>
      </div>
      `;
// to delete task 
      var currenttasks= document.querySelectorAll('.del');
        for(var i=0;i<currenttasks.length;i++){
          currenttasks[i].onclick=function(){
            this.parentNode.remove();
          }
        }
 }
 $(document).ready(function() {
  // click events on checkboxes
  $(document).on('change', '.check', function() {
      if ($(this).prop('checked')) {
          $(this).parent().css("background-color", "yellow");
      } else {
          $(this).parent().css("background-color", ""); // Clear the background color when unchecked
      }
  });
});
}