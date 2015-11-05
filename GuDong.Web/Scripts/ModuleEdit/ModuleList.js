

function dataDelete(id,control,action) {
    if (!confirm('确定删除？'))
        return;
    $.ajax({
        url: '/' + control + '/' + action + ''
        , data: ({ id: id })
        , type: 'POST'
        , success: function (data) {
            alert(data);
            location.reload();
        }
    });

}
////, control, action
//function onSearchGo( ) {
//    var txtCode = $('#txtCode').val();
//    $.ajax({
//        url: '/Banner/BannerEditList '
//        , data: ({ txtCode: txtCode })
//        , type: 'POST'
//        , success: function (data) {
             
//        }
//    });

//}
 



       
       
      
