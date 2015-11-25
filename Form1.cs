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
	
	// Horizontals
	if ((a1.Text == a2.Text) && (a2.Text == a3.Text))
		someoneWins = true;
	if ((b1.Text == b2.Text) && (b2.Text == b3.Text))
		someoneWins = true;
	if ((c1.Text == b2.Text) && (b2.Text == a3.Text))
		someoneWins = true;
	
	// Andrew's cross
	if ((a1.Text == a2.Text) && (b2.Text == c3.Text)){
		someoneWins = true;
		
	}
	if ((c1.Text == c2.Text) && (c2.Text == c3.Text))
		someoneWins = true;
	
	// verticals
	if ((a1.Text == b1.Text) && (b1.Text == c1.Text))
		someoneWins = true;
	if ((a2.Text == b2.Text) && (b2.Text == c2.Text))
		someoneWins = true;
	if ((a3.Text == b3.Text) && (b3.Text == c3.Text))
		someoneWins = true;
}

public void printWinner(string winnerName){
	
}

public void printWinner(bool turn){
	disableOtherButtons();
	char winner = 'X';
	if (turn == true)
		winner = 'O';
	MessageBox.Show(winner + "wins!");
}

private void disableOtherButtons(){
	try{
		foreach (Control c in Controls){
			Button b = (Button)c;
			c.Enabled = false;
		}// end foreach
	}// end try 
	catch (RuntimeException rEx){}
}
