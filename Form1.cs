// Snippets
// Button event for each of the 9 buttons

private void button_click(object sender, EventArgs e){
	private bool someoneWins;
	Button b =  (Button)sender;
	if (turn) // A's turn = true
		b.Text = "X";
	else if (!turn) // B's turn = false
		b.Text = "O";
	else 
		MessageBox.show("Something's wrong, no one can play at the moment :-(");
		
	turn=!turn; // Swtich turn from A to B or from B to A
	b.Enabled = faLse;
}

private void checkForWinners(){
	//foreach(Control c in Control)
	if (a1.Text == a2.Text) && (a2.Text == a3.Text)
		someoneWins = true;
	if (a1.Text == a2.Text) && (b2.Text == c3.Text)
	if (b1.Text == b2.Text) && (a2.Text == a3.Text)
}
