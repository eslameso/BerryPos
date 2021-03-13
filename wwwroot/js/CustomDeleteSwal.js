function CustomDelete(url,dataId){
swal({
    title: "Are you sure?",
    text: "You will not be able to recover this Item",
    type: "warning",
    showCancelButton: true,
    confirmButtonClass: "btn-danger",
    confirmButtonText: "Yes, delete it!",
    cancelButtonText: "No, cancel plx!",
    closeOnConfirm: false,
    closeOnCancel: false
  },
  function(isConfirm) {
    debugger;
    if (isConfirm) {
      $.ajax({
        url:url,
        data:{Id:dataId},
        success:function(result){
           if(result){
           swal({
              title:"Deleted!", 
              text:"Successfully deleted.", 
              type:"success"
               },
          function(isConfirm){
          if(isConfirm){
            location.reload();
          }
      });
               }
      else{
  swal({
              title:"Notes!", 
              text:"Sorry ! This Item Cannot Delete.", 
              type:"error"
               });
      }
      
  
      }
  
      });
     
    } else {
      swal("Cancelled", "Your Item is safe :)", "error");
    }
  });
}