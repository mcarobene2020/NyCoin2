function formatCurrency(value) {
    if (value === undefined || value === null || value === "") return 0;

    var v = value;
    value = (value.toLocaleString().indexOf(",") === -1 ?
        value.toLocaleString() + ",00" :
        value.toLocaleString().split(",")[0] + "," + value.toLocaleString().split(",")[1].padEnd(2, "0"));
    return value;
}