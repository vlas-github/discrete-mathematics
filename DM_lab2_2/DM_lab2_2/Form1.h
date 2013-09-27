#pragma once

namespace DM_lab2_2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^  pnlTitle;
	protected: 
	private: System::Windows::Forms::Label^  lblTitle2;
	private: System::Windows::Forms::Label^  lblTitle1;
	private: System::Windows::Forms::GroupBox^  gbxLab2;
	private: System::Windows::Forms::GroupBox^  gbxOutbut;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  lblEqualityOfSets2;
	private: System::Windows::Forms::Label^  lblIncludedOfSets2;
	private: System::Windows::Forms::Label^  lblEqualityOfSets;
	private: System::Windows::Forms::Label^  lblIncludedOfSets;
	private: System::Windows::Forms::Label^  lblDifferenceOfSets;
	private: System::Windows::Forms::Label^  lblUnionOfSets;
	private: System::Windows::Forms::Label^  lblIntersectionOfSets;
	private: System::Windows::Forms::Button^  btnExit;
	private: System::Windows::Forms::Button^  btnClear;
	private: System::Windows::Forms::Button^  btnOK;
	private: System::Windows::Forms::GroupBox^  gbxInput;
	private: System::Windows::Forms::TextBox^  tbSizeB;
	private: System::Windows::Forms::TextBox^  tbSizeA;
	private: System::Windows::Forms::Label^  lblSizeB;
	private: System::Windows::Forms::Label^  lblSizeA;
	private: System::Windows::Forms::Label^  lblSetB;
	private: System::Windows::Forms::Label^  lblSetA;
	private: System::Windows::Forms::Label^  lblB;
	private: System::Windows::Forms::Label^  lblA;

	private:
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->pnlTitle = (gcnew System::Windows::Forms::Panel());
			this->lblTitle2 = (gcnew System::Windows::Forms::Label());
			this->lblTitle1 = (gcnew System::Windows::Forms::Label());
			this->gbxLab2 = (gcnew System::Windows::Forms::GroupBox());
			this->gbxOutbut = (gcnew System::Windows::Forms::GroupBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->lblEqualityOfSets2 = (gcnew System::Windows::Forms::Label());
			this->lblIncludedOfSets2 = (gcnew System::Windows::Forms::Label());
			this->lblEqualityOfSets = (gcnew System::Windows::Forms::Label());
			this->lblIncludedOfSets = (gcnew System::Windows::Forms::Label());
			this->lblDifferenceOfSets = (gcnew System::Windows::Forms::Label());
			this->lblUnionOfSets = (gcnew System::Windows::Forms::Label());
			this->lblIntersectionOfSets = (gcnew System::Windows::Forms::Label());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->btnClear = (gcnew System::Windows::Forms::Button());
			this->btnOK = (gcnew System::Windows::Forms::Button());
			this->gbxInput = (gcnew System::Windows::Forms::GroupBox());
			this->tbSizeB = (gcnew System::Windows::Forms::TextBox());
			this->tbSizeA = (gcnew System::Windows::Forms::TextBox());
			this->lblSizeB = (gcnew System::Windows::Forms::Label());
			this->lblSizeA = (gcnew System::Windows::Forms::Label());
			this->lblSetB = (gcnew System::Windows::Forms::Label());
			this->lblSetA = (gcnew System::Windows::Forms::Label());
			this->lblB = (gcnew System::Windows::Forms::Label());
			this->lblA = (gcnew System::Windows::Forms::Label());
			this->pnlTitle->SuspendLayout();
			this->gbxLab2->SuspendLayout();
			this->gbxOutbut->SuspendLayout();
			this->gbxInput->SuspendLayout();
			this->SuspendLayout();
			// 
			// pnlTitle
			// 
			this->pnlTitle->Controls->Add(this->lblTitle2);
			this->pnlTitle->Controls->Add(this->lblTitle1);
			this->pnlTitle->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnlTitle->Location = System::Drawing::Point(0, 0);
			this->pnlTitle->Name = L"pnlTitle";
			this->pnlTitle->Size = System::Drawing::Size(457, 79);
			this->pnlTitle->TabIndex = 2;
			// 
			// lblTitle2
			// 
			this->lblTitle2->Dock = System::Windows::Forms::DockStyle::Fill;
			this->lblTitle2->Location = System::Drawing::Point(0, 22);
			this->lblTitle2->Margin = System::Windows::Forms::Padding(5);
			this->lblTitle2->Name = L"lblTitle2";
			this->lblTitle2->Padding = System::Windows::Forms::Padding(5);
			this->lblTitle2->Size = System::Drawing::Size(457, 57);
			this->lblTitle2->TabIndex = 3;
			this->lblTitle2->Text = L"«Моделирование операций «пересечение», «объединение», «разность», «вхождение» и «" 
				L"равенство» для двух числовых множеств»";
			this->lblTitle2->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// lblTitle1
			// 
			this->lblTitle1->Dock = System::Windows::Forms::DockStyle::Top;
			this->lblTitle1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(204)));
			this->lblTitle1->Location = System::Drawing::Point(0, 0);
			this->lblTitle1->Margin = System::Windows::Forms::Padding(5);
			this->lblTitle1->Name = L"lblTitle1";
			this->lblTitle1->Padding = System::Windows::Forms::Padding(5);
			this->lblTitle1->Size = System::Drawing::Size(457, 22);
			this->lblTitle1->TabIndex = 2;
			this->lblTitle1->Text = L"Лабораторная работа №2";
			this->lblTitle1->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// gbxLab2
			// 
			this->gbxLab2->Controls->Add(this->gbxOutbut);
			this->gbxLab2->Controls->Add(this->btnExit);
			this->gbxLab2->Controls->Add(this->btnClear);
			this->gbxLab2->Controls->Add(this->btnOK);
			this->gbxLab2->Controls->Add(this->gbxInput);
			this->gbxLab2->Dock = System::Windows::Forms::DockStyle::Fill;
			this->gbxLab2->Location = System::Drawing::Point(0, 79);
			this->gbxLab2->Margin = System::Windows::Forms::Padding(10);
			this->gbxLab2->Name = L"gbxLab2";
			this->gbxLab2->Size = System::Drawing::Size(457, 393);
			this->gbxLab2->TabIndex = 3;
			this->gbxLab2->TabStop = false;
			this->gbxLab2->Text = L"Выполнение:";
			// 
			// gbxOutbut
			// 
			this->gbxOutbut->Controls->Add(this->label1);
			this->gbxOutbut->Controls->Add(this->label2);
			this->gbxOutbut->Controls->Add(this->label3);
			this->gbxOutbut->Controls->Add(this->label4);
			this->gbxOutbut->Controls->Add(this->label5);
			this->gbxOutbut->Controls->Add(this->label6);
			this->gbxOutbut->Controls->Add(this->label7);
			this->gbxOutbut->Controls->Add(this->lblEqualityOfSets2);
			this->gbxOutbut->Controls->Add(this->lblIncludedOfSets2);
			this->gbxOutbut->Controls->Add(this->lblEqualityOfSets);
			this->gbxOutbut->Controls->Add(this->lblIncludedOfSets);
			this->gbxOutbut->Controls->Add(this->lblDifferenceOfSets);
			this->gbxOutbut->Controls->Add(this->lblUnionOfSets);
			this->gbxOutbut->Controls->Add(this->lblIntersectionOfSets);
			this->gbxOutbut->Dock = System::Windows::Forms::DockStyle::Fill;
			this->gbxOutbut->Location = System::Drawing::Point(3, 205);
			this->gbxOutbut->Name = L"gbxOutbut";
			this->gbxOutbut->Size = System::Drawing::Size(451, 185);
			this->gbxOutbut->TabIndex = 10;
			this->gbxOutbut->TabStop = false;
			this->gbxOutbut->Text = L"Выходные данные";
			this->gbxOutbut->Enter += gcnew System::EventHandler(this, &Form1::gbxOutbut_Enter);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(122, 164);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 13);
			this->label1->TabIndex = 18;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(122, 140);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(0, 13);
			this->label2->TabIndex = 17;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(122, 117);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(0, 13);
			this->label3->TabIndex = 16;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(122, 93);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(0, 13);
			this->label4->TabIndex = 15;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(122, 70);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(0, 13);
			this->label5->TabIndex = 14;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(122, 47);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(0, 13);
			this->label6->TabIndex = 13;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(122, 24);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(0, 13);
			this->label7->TabIndex = 12;
			// 
			// lblEqualityOfSets2
			// 
			this->lblEqualityOfSets2->AutoSize = true;
			this->lblEqualityOfSets2->Location = System::Drawing::Point(10, 164);
			this->lblEqualityOfSets2->Name = L"lblEqualityOfSets2";
			this->lblEqualityOfSets2->Size = System::Drawing::Size(93, 13);
			this->lblEqualityOfSets2->TabIndex = 11;
			this->lblEqualityOfSets2->Text = L"Равенство В и В:";
			// 
			// lblIncludedOfSets2
			// 
			this->lblIncludedOfSets2->AutoSize = true;
			this->lblIncludedOfSets2->Location = System::Drawing::Point(10, 140);
			this->lblIncludedOfSets2->Name = L"lblIncludedOfSets2";
			this->lblIncludedOfSets2->Size = System::Drawing::Size(95, 13);
			this->lblIncludedOfSets2->TabIndex = 10;
			this->lblIncludedOfSets2->Text = L"Включение А в А:";
			// 
			// lblEqualityOfSets
			// 
			this->lblEqualityOfSets->AutoSize = true;
			this->lblEqualityOfSets->Location = System::Drawing::Point(10, 117);
			this->lblEqualityOfSets->Name = L"lblEqualityOfSets";
			this->lblEqualityOfSets->Size = System::Drawing::Size(93, 13);
			this->lblEqualityOfSets->TabIndex = 4;
			this->lblEqualityOfSets->Text = L"Равенство А и В:";
			// 
			// lblIncludedOfSets
			// 
			this->lblIncludedOfSets->AutoSize = true;
			this->lblIncludedOfSets->Location = System::Drawing::Point(10, 93);
			this->lblIncludedOfSets->Name = L"lblIncludedOfSets";
			this->lblIncludedOfSets->Size = System::Drawing::Size(95, 13);
			this->lblIncludedOfSets->TabIndex = 3;
			this->lblIncludedOfSets->Text = L"Включение А в В:";
			// 
			// lblDifferenceOfSets
			// 
			this->lblDifferenceOfSets->AutoSize = true;
			this->lblDifferenceOfSets->Location = System::Drawing::Point(10, 70);
			this->lblDifferenceOfSets->Name = L"lblDifferenceOfSets";
			this->lblDifferenceOfSets->Size = System::Drawing::Size(87, 13);
			this->lblDifferenceOfSets->TabIndex = 2;
			this->lblDifferenceOfSets->Text = L"Разность А и В:";
			// 
			// lblUnionOfSets
			// 
			this->lblUnionOfSets->AutoSize = true;
			this->lblUnionOfSets->Location = System::Drawing::Point(10, 47);
			this->lblUnionOfSets->Name = L"lblUnionOfSets";
			this->lblUnionOfSets->Size = System::Drawing::Size(108, 13);
			this->lblUnionOfSets->TabIndex = 1;
			this->lblUnionOfSets->Text = L"Объединение А и В:";
			// 
			// lblIntersectionOfSets
			// 
			this->lblIntersectionOfSets->AutoSize = true;
			this->lblIntersectionOfSets->Location = System::Drawing::Point(10, 24);
			this->lblIntersectionOfSets->Name = L"lblIntersectionOfSets";
			this->lblIntersectionOfSets->Size = System::Drawing::Size(106, 13);
			this->lblIntersectionOfSets->TabIndex = 0;
			this->lblIntersectionOfSets->Text = L"Пересечение А и В:";
			// 
			// btnExit
			// 
			this->btnExit->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnExit->Location = System::Drawing::Point(3, 182);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(451, 23);
			this->btnExit->TabIndex = 9;
			this->btnExit->Text = L"Выход";
			this->btnExit->UseVisualStyleBackColor = true;
			this->btnExit->Click += gcnew System::EventHandler(this, &Form1::btnExit_Click);
			// 
			// btnClear
			// 
			this->btnClear->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnClear->Location = System::Drawing::Point(3, 159);
			this->btnClear->Name = L"btnClear";
			this->btnClear->Size = System::Drawing::Size(451, 23);
			this->btnClear->TabIndex = 8;
			this->btnClear->Text = L"Очистить";
			this->btnClear->UseVisualStyleBackColor = true;
			this->btnClear->Click += gcnew System::EventHandler(this, &Form1::btnClear_Click);
			// 
			// btnOK
			// 
			this->btnOK->Dock = System::Windows::Forms::DockStyle::Top;
			this->btnOK->Location = System::Drawing::Point(3, 136);
			this->btnOK->Name = L"btnOK";
			this->btnOK->Size = System::Drawing::Size(451, 23);
			this->btnOK->TabIndex = 6;
			this->btnOK->Text = L"Выполнить";
			this->btnOK->UseVisualStyleBackColor = true;
			this->btnOK->Click += gcnew System::EventHandler(this, &Form1::btnOK_Click);
			// 
			// gbxInput
			// 
			this->gbxInput->Controls->Add(this->tbSizeB);
			this->gbxInput->Controls->Add(this->tbSizeA);
			this->gbxInput->Controls->Add(this->lblSizeB);
			this->gbxInput->Controls->Add(this->lblSizeA);
			this->gbxInput->Controls->Add(this->lblSetB);
			this->gbxInput->Controls->Add(this->lblSetA);
			this->gbxInput->Controls->Add(this->lblB);
			this->gbxInput->Controls->Add(this->lblA);
			this->gbxInput->Dock = System::Windows::Forms::DockStyle::Top;
			this->gbxInput->Location = System::Drawing::Point(3, 16);
			this->gbxInput->Name = L"gbxInput";
			this->gbxInput->Size = System::Drawing::Size(451, 120);
			this->gbxInput->TabIndex = 0;
			this->gbxInput->TabStop = false;
			this->gbxInput->Text = L"Исходные данные:";
			// 
			// tbSizeB
			// 
			this->tbSizeB->Location = System::Drawing::Point(135, 41);
			this->tbSizeB->Name = L"tbSizeB";
			this->tbSizeB->Size = System::Drawing::Size(50, 20);
			this->tbSizeB->TabIndex = 7;
			// 
			// tbSizeA
			// 
			this->tbSizeA->Location = System::Drawing::Point(135, 17);
			this->tbSizeA->Name = L"tbSizeA";
			this->tbSizeA->Size = System::Drawing::Size(50, 20);
			this->tbSizeA->TabIndex = 6;
			// 
			// lblSizeB
			// 
			this->lblSizeB->AutoSize = true;
			this->lblSizeB->Location = System::Drawing::Point(10, 44);
			this->lblSizeB->Name = L"lblSizeB";
			this->lblSizeB->Size = System::Drawing::Size(119, 13);
			this->lblSizeB->TabIndex = 5;
			this->lblSizeB->Text = L"Размер множества В:";
			// 
			// lblSizeA
			// 
			this->lblSizeA->AutoSize = true;
			this->lblSizeA->Location = System::Drawing::Point(10, 20);
			this->lblSizeA->Name = L"lblSizeA";
			this->lblSizeA->Size = System::Drawing::Size(119, 13);
			this->lblSizeA->TabIndex = 4;
			this->lblSizeA->Text = L"Размер множества А:";
			// 
			// lblSetB
			// 
			this->lblSetB->AutoSize = true;
			this->lblSetB->Location = System::Drawing::Point(97, 94);
			this->lblSetB->Name = L"lblSetB";
			this->lblSetB->Size = System::Drawing::Size(0, 13);
			this->lblSetB->TabIndex = 3;
			// 
			// lblSetA
			// 
			this->lblSetA->AutoSize = true;
			this->lblSetA->Location = System::Drawing::Point(97, 69);
			this->lblSetA->Name = L"lblSetA";
			this->lblSetA->Size = System::Drawing::Size(0, 13);
			this->lblSetA->TabIndex = 2;
			// 
			// lblB
			// 
			this->lblB->AutoSize = true;
			this->lblB->Location = System::Drawing::Point(10, 94);
			this->lblB->Name = L"lblB";
			this->lblB->Size = System::Drawing::Size(78, 13);
			this->lblB->TabIndex = 1;
			this->lblB->Text = L"Множество В:";
			// 
			// lblA
			// 
			this->lblA->AutoSize = true;
			this->lblA->Location = System::Drawing::Point(10, 69);
			this->lblA->Name = L"lblA";
			this->lblA->Size = System::Drawing::Size(78, 13);
			this->lblA->TabIndex = 0;
			this->lblA->Text = L"Множество А:";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(457, 472);
			this->Controls->Add(this->gbxLab2);
			this->Controls->Add(this->pnlTitle);
			this->Name = L"Form1";
			this->Text = L"Лабораторная работа №2";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->pnlTitle->ResumeLayout(false);
			this->gbxLab2->ResumeLayout(false);
			this->gbxOutbut->ResumeLayout(false);
			this->gbxOutbut->PerformLayout();
			this->gbxInput->ResumeLayout(false);
			this->gbxInput->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {

				 randObj = gcnew Random(20);

				 lblSetA->Text = "{ }";
				 lblSetB->Text = "{ }";

				 tbSizeA->Text = "10";
				 tbSizeB->Text = "15";

				 label1->Text = "{ }";
				 label2->Text = "{ }";
				 label3->Text = "{ }";
				 label4->Text = "{ }";
				 label5->Text = "{ }";
				 label6->Text = "{ }";
				 label7->Text = "{ }";
			 }
	private: System::Void btnClear_Click(System::Object^  sender, System::EventArgs^  e) {

				 lblSetA->Text = "{ }";
				 lblSetB->Text = "{ }";

				 tbSizeA->Text = "10";
				 tbSizeB->Text = "15";

				 label1->Text = "{ }";
				 label2->Text = "{ }";
				 label3->Text = "{ }";
				 label4->Text = "{ }";
				 label5->Text = "{ }";
				 label6->Text = "{ }";
				 label7->Text = "{ }";
			 }  
	private: System::Void btnExit_Click(System::Object^  sender, System::EventArgs^  e) {

				 Application::Exit();
			 }
	private: System::Void btnOK_Click(System::Object^  sender, System::EventArgs^  e) {
				 
				int n = Convert::ToInt32(tbSizeA->Text);
				int m = Convert::ToInt32(tbSizeB->Text);

				int *A = generate(n);
				int *B = generate(m);

				sort(A, n);
				sort(B, m);

				int k1, k2, k3 = 0;
				int *C = intersectionOfSets(A, B, n, m, k1);
				int *D = unionOfSets(A, B, n, m, k2);
				int *E = differenceOfSets(A, B, n, m, k3);

				sort(C, k1);
				sort(D, k2);
				sort(E, k3);

				lblSetA->Text = print(A, n);
				lblSetB->Text = print(B, m);

				label1->Text = Convert::ToString(equalityOfSets(B, B, m, m));
				label2->Text = Convert::ToString(includedOfSets(A, A, n, n));
				label3->Text = Convert::ToString(equalityOfSets(A, B, n, m));
				label4->Text = Convert::ToString(includedOfSets(A, B, n, m));
				label5->Text = print(E, k3);
				label6->Text = print(D, k2);
				label7->Text = print(C, k1);
			 }

	Random^ randObj;

int *generate(int size)
{
	int *mas = new int[size];

	

	for(int i = 0; i < size; i++)
	{
		bool f = true;
		int tmp = 0;

		while (f) 
		{
			tmp = randObj->Next(1, 20);
			f = false;

			for (int j = 0; j < i; j++)
			{
				if(mas[j] == tmp)
					f = true;
			}
		}

		mas[i] = tmp;
	}

	return mas;
}
int *intersectionOfSets(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (A[i] == B[j])
			{
				bool f = true;

				for(int l = 0; l < k; l++)
				{
					if (mas[l] == A[i])
						f = false;
				}

				if(f)
				{
					mas[k] = A[i];
					k++;
				}
			}
		}
	}

	return mas;
}
int *unionOfSets(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		bool f = true;

		for (int j = 0; j < k; j++)
		{
			if (mas[j] == A[i])
				f = false;
		}

		if(f)
		{
			mas[k] = A[i];
			k++;
		}
	}

	for (int i = 0; i < m; i++)
	{
		bool f = true;

		for (int j = 0; j < k; j++)
		{
			if (mas[j] == B[i])
				f = false;
		}

		if(f)
		{
			mas[k] = B[i];
			k++;
		}
	}

	return mas;
}
int *differenceOfSets(int *A, int *B, int n, int m, int &k)
{
	int *mas = new int[n + m];

	k = 0;

	for (int i = 0; i < n; i++)
	{
		bool f = true;

		for (int j = 0; j < m; j++)
		{
			for(int l = 0; l < k; l++)
			{
				if (mas[l] == A[i])
					f = false;
			}

			if (A[i] == B[j])
				f = false;
		}

		if(f)
		{
			mas[k] = A[i];
			k++;
		}
	}

	return mas;
}
bool includedOfSets(int *A, int *B, int n, int m)
{
	if (n > m)
		return false;

	for (int i = 0; i < n; i++)
	{
		bool f = false;

		for (int j = 0; j < m; j++)
		{
			if (A[i] == B[j])
			{
				f = true;
			}
		}

		if (!f)
			return false;
	}

	return true;
}
bool equalityOfSets(int *A, int *B, int n, int m)
{
	if (n != m)
		return false;

	return includedOfSets(A, B, n, m) && includedOfSets(B, A, m, n);
}
String^ print(int *A, int size)
{
	String^ result = "";

	result += "{ ";

	for (int i = 0; i < size; i++)
	{
		if(i == size - 1)
			result += Convert::ToString(A[i]);
		else
			result += Convert::ToString(A[i]) + ", ";
	}

	result += " }";

	return result;
}
void sort(int *A, int size)
{
	for(int i = 0; i < size - 1; i++)
	{
		for(int j = i + 1; j < size; j++)
		{
			if(A[i] > A[j])
			{
				int tmp = A[i];
				A[i] = A[j];
				A[j] = tmp;
			}
		}
	}
}

private: System::Void gbxOutbut_Enter(System::Object^  sender, System::EventArgs^  e) {
		 }
};
}

