// Snippets
// Button event for each of the 9 buttons

private void button_click(object sender, EventArgs e){
	private bool someoneWins=false;
	Button b =  (Button)sender;
	if (turn) // A's turn = true
		b.Text = "X";
	else if (!turn) // B's turn = false
		b.Text = "O";
	else 
		MessageBox.show("Something's wrong, no one can play at the moment :-(");
	
	turnCount++;
	turn=!turn; // Swtich turn from A to B or from B to A
	b.Enabled = faLse;
	while (turnCount <= 9){
		while (someoneWins==false){
			someoneWins=checkForWinners(someoneWins);
		} //end while
	}// end both whiles
}

private bool checkForWinners(bool someoneWins){
	//foreach(Control c in Control)
	
	// Horizontals
	if ((a1.Text == a2.Text) && (a2.Text == a3.Text))
		return true;
	else if ((b1.Text == b2.Text) && (b2.Text == b3.Text))
		return true;
	else if ((c1.Text == b2.Text) && (b2.Text == a3.Text))
		return true;
	
	// Andrew's cross
	else if ((a1.Text == a2.Text) && (b2.Text == c3.Text)){
		return true;
		
	}
	else if ((c1.Text == c2.Text) && (c2.Text == c3.Text))
		return true;
	
	// verticals
	else if ((a1.Text == b1.Text) && (b1.Text == c1.Text))
		return true;
	else if ((a2.Text == b2.Text) && (b2.Text == c2.Text))
		return true;
	else if ((a3.Text == b3.Text) && (b3.Text == c3.Text))
		return true;
	
	else if (turnCount == 9)
		return false;
		
}

public void printWinner(string winnerName, bool someoneWins){
	
}

public void printWinner(bool turn, bool someoneWins){
	disableOtherButtons();
	if (someoneWins){
	char winner = 'X';
	if (turn == true)
		winner = 'O';
	MessageBox.Show(winner + "wins!");
	} // end if
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
