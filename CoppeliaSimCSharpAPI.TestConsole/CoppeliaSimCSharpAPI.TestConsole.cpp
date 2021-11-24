
#include "CoppeliaSimCSharpAPI.TestConsole.h"

using namespace std;

int main()
{
    string command = "";

    cout << "CoppeliaSim C# API Test Console\n\n";
    while (true)
    {
        cin >> command;
        cout << "Get " << command << "\n";
    }
    return 0;
}

