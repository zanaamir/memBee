function AjaxJsonHandler(_url , _type,_data , success_callback, error_callback) {

 
    $.ajax({
        datatype: "json",
        url: _url,
        contentType: "application/json; charset=utf-8",
        method: _type,
        data: JSON.stringify(_data),
        success: success_callback,
        error: error_callback
    });
}

function GenericError(err){
    console.log(err);
   
    
}
function AlredyExist(err) {
    alert("הלקוח כבר רשום למועדון זה");
}


var systemHelper = {
    webApiEndPoints: {
        login: "/api/LOGIN",
        club: "/api/club/",
        customer: "/api/club",
        AddCustomerToClub: "/api/AddCustomerToClub/",
        CategoryChoice: "/api/CategoryChoice",
        Child: "/api/Child"

    },
    HttpVerbs: {
        POST: "POST",
        GET: "GET",
        DELETE: "DELETE",
        PUT: "PUT"


    },
    storege: {
        user: "user",
        club: "club", // changed from clubId : "clubId"
        NewClient: "NewClient",
        NewChild: "NewChild"

    },
    getFromStorege: function (key) {
        return JSON.parse(localStorage.getItem(key));
    }
};



