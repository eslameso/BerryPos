function tablePlugin(selector, url, columns) {

    var tab = $(selector).DataTable({
        lengthChange: true,
        info: true,
        searching: true,
        search: true,
        ordering: true,
        responsive: true,
        searchable: true,
        processing: true,
        serverSide: true,
        ajax: {
            url: url,
            async: true,
            dataSrc: function (json) {

                console.log(json);
                return json.data;
            }
        },
        columns: columns

    });
    return tab;
}