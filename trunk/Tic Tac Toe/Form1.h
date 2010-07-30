#pragma once

namespace TicTacToe {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	internal: System::Windows::Forms::Label^  lblturns;
	protected: 
	internal: System::Windows::Forms::GroupBox^  GroupBox1;
	internal: System::Windows::Forms::RadioButton^  radImp;
	internal: System::Windows::Forms::RadioButton^  radHard;
	internal: System::Windows::Forms::RadioButton^  radNormal;
	internal: System::Windows::Forms::RadioButton^  radEasy;
	internal: System::Windows::Forms::Button^  btnExit;
	internal: System::Windows::Forms::GroupBox^  grpMode;
	internal: System::Windows::Forms::RadioButton^  rad2P;
	internal: System::Windows::Forms::RadioButton^  radComp;
	internal: System::Windows::Forms::Button^  btnNewGame;
	internal: System::Windows::Forms::Label^  lblTurn;
	internal: System::Windows::Forms::Button^  Button9;
	internal: System::Windows::Forms::Button^  Button8;
	internal: System::Windows::Forms::Button^  Button7;
	internal: System::Windows::Forms::Button^  Button6;
	internal: System::Windows::Forms::Button^  Button5;
	internal: System::Windows::Forms::Button^  Button4;
	internal: System::Windows::Forms::Button^  Button3;
	internal: System::Windows::Forms::Button^  Button2;
	internal: System::Windows::Forms::Button^  Button1;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lblturns = (gcnew System::Windows::Forms::Label());
			this->GroupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->radImp = (gcnew System::Windows::Forms::RadioButton());
			this->radHard = (gcnew System::Windows::Forms::RadioButton());
			this->radNormal = (gcnew System::Windows::Forms::RadioButton());
			this->radEasy = (gcnew System::Windows::Forms::RadioButton());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->grpMode = (gcnew System::Windows::Forms::GroupBox());
			this->rad2P = (gcnew System::Windows::Forms::RadioButton());
			this->radComp = (gcnew System::Windows::Forms::RadioButton());
			this->btnNewGame = (gcnew System::Windows::Forms::Button());
			this->lblTurn = (gcnew System::Windows::Forms::Label());
			this->Button9 = (gcnew System::Windows::Forms::Button());
			this->Button8 = (gcnew System::Windows::Forms::Button());
			this->Button7 = (gcnew System::Windows::Forms::Button());
			this->Button6 = (gcnew System::Windows::Forms::Button());
			this->Button5 = (gcnew System::Windows::Forms::Button());
			this->Button4 = (gcnew System::Windows::Forms::Button());
			this->Button3 = (gcnew System::Windows::Forms::Button());
			this->Button2 = (gcnew System::Windows::Forms::Button());
			this->Button1 = (gcnew System::Windows::Forms::Button());
			this->GroupBox1->SuspendLayout();
			this->grpMode->SuspendLayout();
			this->SuspendLayout();
			// 
			// lblturns
			// 
			this->lblturns->Location = System::Drawing::Point(28, 245);
			this->lblturns->Name = L"lblturns";
			this->lblturns->Size = System::Drawing::Size(195, 28);
			this->lblturns->TabIndex = 32;
			// 
			// GroupBox1
			// 
			this->GroupBox1->Controls->Add(this->radImp);
			this->GroupBox1->Controls->Add(this->radHard);
			this->GroupBox1->Controls->Add(this->radNormal);
			this->GroupBox1->Controls->Add(this->radEasy);
			this->GroupBox1->Location = System::Drawing::Point(253, 148);
			this->GroupBox1->Name = L"GroupBox1";
			this->GroupBox1->Size = System::Drawing::Size(181, 80);
			this->GroupBox1->TabIndex = 31;
			this->GroupBox1->TabStop = false;
			this->GroupBox1->Text = L"Difficulty";
			// 
			// radImp
			// 
			this->radImp->AutoSize = true;
			this->radImp->Checked = true;
			this->radImp->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)), 
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->radImp->ForeColor = System::Drawing::Color::Red;
			this->radImp->Location = System::Drawing::Point(46, 45);
			this->radImp->Name = L"radImp";
			this->radImp->Size = System::Drawing::Size(92, 20);
			this->radImp->TabIndex = 3;
			this->radImp->TabStop = true;
			this->radImp->Text = L"Impossible";
			this->radImp->UseVisualStyleBackColor = true;
			// 
			// radHard
			// 
			this->radHard->AutoSize = true;
			this->radHard->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->radHard->Location = System::Drawing::Point(125, 19);
			this->radHard->Name = L"radHard";
			this->radHard->Size = System::Drawing::Size(53, 20);
			this->radHard->TabIndex = 2;
			this->radHard->Text = L"Hard";
			this->radHard->UseVisualStyleBackColor = true;
			// 
			// radNormal
			// 
			this->radNormal->AutoSize = true;
			this->radNormal->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->radNormal->Location = System::Drawing::Point(61, 19);
			this->radNormal->Name = L"radNormal";
			this->radNormal->Size = System::Drawing::Size(67, 20);
			this->radNormal->TabIndex = 1;
			this->radNormal->Text = L"Normal";
			this->radNormal->UseVisualStyleBackColor = true;
			// 
			// radEasy
			// 
			this->radEasy->AutoSize = true;
			this->radEasy->Font = (gcnew System::Drawing::Font(L"Arial", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->radEasy->Location = System::Drawing::Point(7, 19);
			this->radEasy->Name = L"radEasy";
			this->radEasy->Size = System::Drawing::Size(56, 20);
			this->radEasy->TabIndex = 0;
			this->radEasy->Text = L"Easy";
			this->radEasy->UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this->btnExit->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btnExit->Font = (gcnew System::Drawing::Font(L"Tahoma", 12, System::Drawing::FontStyle::Bold));
			this->btnExit->Location = System::Drawing::Point(260, 279);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(134, 35);
			this->btnExit->TabIndex = 30;
			this->btnExit->Text = L"Exit Game";
			this->btnExit->UseVisualStyleBackColor = false;
			// 
			// grpMode
			// 
			this->grpMode->Controls->Add(this->rad2P);
			this->grpMode->Controls->Add(this->radComp);
			this->grpMode->Location = System::Drawing::Point(251, 64);
			this->grpMode->Name = L"grpMode";
			this->grpMode->Size = System::Drawing::Size(166, 61);
			this->grpMode->TabIndex = 29;
			this->grpMode->TabStop = false;
			this->grpMode->Text = L"Game Mode";
			// 
			// rad2P
			// 
			this->rad2P->AutoSize = true;
			this->rad2P->Location = System::Drawing::Point(12, 39);
			this->rad2P->Name = L"rad2P";
			this->rad2P->Size = System::Drawing::Size(63, 17);
			this->rad2P->TabIndex = 12;
			this->rad2P->Text = L"2 Player";
			this->rad2P->UseVisualStyleBackColor = true;
			// 
			// radComp
			// 
			this->radComp->AutoSize = true;
			this->radComp->Checked = true;
			this->radComp->Location = System::Drawing::Point(11, 17);
			this->radComp->Name = L"radComp";
			this->radComp->Size = System::Drawing::Size(70, 17);
			this->radComp->TabIndex = 11;
			this->radComp->TabStop = true;
			this->radComp->Text = L"Computer";
			this->radComp->UseVisualStyleBackColor = true;
			// 
			// btnNewGame
			// 
			this->btnNewGame->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->btnNewGame->Font = (gcnew System::Drawing::Font(L"Tahoma", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->btnNewGame->Location = System::Drawing::Point(257, 238);
			this->btnNewGame->Name = L"btnNewGame";
			this->btnNewGame->Size = System::Drawing::Size(138, 35);
			this->btnNewGame->TabIndex = 28;
			this->btnNewGame->Text = L"New Game";
			this->btnNewGame->UseVisualStyleBackColor = false;
			// 
			// lblTurn
			// 
			this->lblTurn->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->lblTurn->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->lblTurn->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->lblTurn->Location = System::Drawing::Point(257, 9);
			this->lblTurn->Name = L"lblTurn";
			this->lblTurn->Size = System::Drawing::Size(97, 50);
			this->lblTurn->TabIndex = 27;
			this->lblTurn->Text = L"X";
			this->lblTurn->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// Button9
			// 
			this->Button9->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button9->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button9->ForeColor = System::Drawing::Color::Yellow;
			this->Button9->Location = System::Drawing::Point(158, 159);
			this->Button9->Name = L"Button9";
			this->Button9->Size = System::Drawing::Size(65, 70);
			this->Button9->TabIndex = 26;
			this->Button9->UseVisualStyleBackColor = false;
			// 
			// Button8
			// 
			this->Button8->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button8->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button8->ForeColor = System::Drawing::Color::Yellow;
			this->Button8->Location = System::Drawing::Point(87, 158);
			this->Button8->Name = L"Button8";
			this->Button8->Size = System::Drawing::Size(65, 70);
			this->Button8->TabIndex = 25;
			this->Button8->UseVisualStyleBackColor = false;
			// 
			// Button7
			// 
			this->Button7->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button7->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button7->ForeColor = System::Drawing::Color::Yellow;
			this->Button7->Location = System::Drawing::Point(16, 158);
			this->Button7->Name = L"Button7";
			this->Button7->Size = System::Drawing::Size(65, 70);
			this->Button7->TabIndex = 24;
			this->Button7->UseVisualStyleBackColor = false;
			// 
			// Button6
			// 
			this->Button6->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button6->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button6->ForeColor = System::Drawing::Color::Yellow;
			this->Button6->Location = System::Drawing::Point(158, 83);
			this->Button6->Name = L"Button6";
			this->Button6->Size = System::Drawing::Size(65, 70);
			this->Button6->TabIndex = 23;
			this->Button6->UseVisualStyleBackColor = false;
			// 
			// Button5
			// 
			this->Button5->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button5->ForeColor = System::Drawing::Color::Yellow;
			this->Button5->Location = System::Drawing::Point(87, 82);
			this->Button5->Name = L"Button5";
			this->Button5->Size = System::Drawing::Size(65, 70);
			this->Button5->TabIndex = 22;
			this->Button5->UseVisualStyleBackColor = false;
			// 
			// Button4
			// 
			this->Button4->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button4->ForeColor = System::Drawing::Color::Yellow;
			this->Button4->Location = System::Drawing::Point(16, 82);
			this->Button4->Name = L"Button4";
			this->Button4->Size = System::Drawing::Size(65, 70);
			this->Button4->TabIndex = 21;
			this->Button4->UseVisualStyleBackColor = false;
			// 
			// Button3
			// 
			this->Button3->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button3->ForeColor = System::Drawing::Color::Yellow;
			this->Button3->Location = System::Drawing::Point(158, 7);
			this->Button3->Name = L"Button3";
			this->Button3->Size = System::Drawing::Size(65, 70);
			this->Button3->TabIndex = 20;
			this->Button3->UseVisualStyleBackColor = false;
			// 
			// Button2
			// 
			this->Button2->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button2->ForeColor = System::Drawing::Color::Yellow;
			this->Button2->Location = System::Drawing::Point(87, 6);
			this->Button2->Name = L"Button2";
			this->Button2->Size = System::Drawing::Size(65, 70);
			this->Button2->TabIndex = 19;
			this->Button2->UseVisualStyleBackColor = false;
			// 
			// Button1
			// 
			this->Button1->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(255)), 
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->Button1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 26.25F, System::Drawing::FontStyle::Bold));
			this->Button1->ForeColor = System::Drawing::Color::Yellow;
			this->Button1->Location = System::Drawing::Point(16, 6);
			this->Button1->Name = L"Button1";
			this->Button1->Size = System::Drawing::Size(65, 70);
			this->Button1->TabIndex = 18;
			this->Button1->UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(457, 357);
			this->Controls->Add(this->lblturns);
			this->Controls->Add(this->GroupBox1);
			this->Controls->Add(this->btnExit);
			this->Controls->Add(this->grpMode);
			this->Controls->Add(this->btnNewGame);
			this->Controls->Add(this->lblTurn);
			this->Controls->Add(this->Button9);
			this->Controls->Add(this->Button8);
			this->Controls->Add(this->Button7);
			this->Controls->Add(this->Button6);
			this->Controls->Add(this->Button5);
			this->Controls->Add(this->Button4);
			this->Controls->Add(this->Button3);
			this->Controls->Add(this->Button2);
			this->Controls->Add(this->Button1);
			this->Name = L"Form1";
			this->Text = L"Tic-Tac-Toe";
			this->GroupBox1->ResumeLayout(false);
			this->GroupBox1->PerformLayout();
			this->grpMode->ResumeLayout(false);
			this->grpMode->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}

