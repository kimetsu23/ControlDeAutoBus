using System;
using System.Drawing;
using System.Windows.Forms;

public class ActionsButtonsColumn : DataGridViewColumn
{
    public ActionsButtonsColumn() : base(new ActionsButtonsCell())
    {
        this.HeaderText = "Acciones";
        this.Width = 180;
        this.ReadOnly = true;
    }
}

public class ActionsButtonsCell : DataGridViewCell
{
    public override Type ValueType => typeof(string);
    public override Type FormattedValueType => typeof(string);

    protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
        DataGridViewElementStates cellState, object value, object formattedValue, string errorText,
        DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
    {
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
            formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

        Rectangle editRect = new Rectangle(
            cellBounds.X + 5,
            cellBounds.Y + 6,
            (cellBounds.Width - 15) / 2,
            cellBounds.Height - 12
        );

        Rectangle deleteRect = new Rectangle(
            editRect.Right + 5,
            cellBounds.Y + 6,
            (cellBounds.Width - 15) / 2,
            cellBounds.Height - 12
        );

        ControlPaint.DrawButton(graphics, editRect, ButtonState.Normal);
        TextRenderer.DrawText(graphics, "Editar", cellStyle.Font, editRect,
            Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        ControlPaint.DrawButton(graphics, deleteRect, ButtonState.Normal);
        TextRenderer.DrawText(graphics, "Eliminar", cellStyle.Font, deleteRect,
            Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
