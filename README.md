# Cybersecurity Awareness Bot - Part 1

## Description
A console-based chatbot designed to educate South African citizens about common cyber threats such as phishing, OTP scams, SARS fraud, and safe online practices.

## Features
- Voice greeting using WAV file
- Colorful ASCII art header with South African flag
- Personalized user name with input validation
- Typewriter effect for conversational feel
- South Africa-specific cybersecurity responses
- Random daily security tip
- Enhanced colored console UI

## How to Run
1. Open the solution in Visual Studio
2. Ensure `greeting.wav` is in the `Assets` folder and set to "Copy always"
3. Build and run the project (F5)

## Technologies Used
- C# (.NET 8)
- System.Media.SoundPlayer
- Console color formatting


GitHub Actions CI is configured and passing.
## GitHub Actions CI Pipeline

This project uses GitHub Actions for Continuous Integration.  
The workflow automatically builds the .NET application whenever code is pushed.

Successful workflow run:


![CI Build Success] (<img width="1440" height="900" alt="Screenshot 2026-03-30 at 16 53 27" src="https://github.com/user-attachments/assets/3d064c23-5d7c-4c34-987a-b77265360ea6" />)
