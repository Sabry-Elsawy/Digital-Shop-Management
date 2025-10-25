﻿namespace WMS_DEPI_GRAD;

public class ReceiptItem
{
    public int Id { get; set; }
    public int ReceiptId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;
    public int Qty { get; set; }

}