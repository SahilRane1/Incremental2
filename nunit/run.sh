#!/bin/bash
if [ ! -d "/home/coder/project/workspace/dotnetapp/" ]
then
    cp -r /home/coder/project/workspace/nunit/dotnetapp /home/coder/project/workspace/;
fi

if [ -d "/home/coder/project/workspace/dotnetapp/" ]
then
    echo "project folder present"
    # checking for src folder
    if [ -d "/home/coder/project/workspace/dotnetapp/" ]
    then
        cp -r /home/coder/project/workspace/nunit/test/TestProject /home/coder/project/workspace/;
        cp -r /home/coder/project/workspace/nunit/test/dotnetapp.sln /home/coder/project/workspace/dotnetapp/;
        cd /home/coder/project/workspace/dotnetapp || exit;
        dotnet clean;
        dotnet build && dotnet test -l "console;verbosity=normal";
    else
        echo "Week2_day5_Player_ClassExists FAILED";
        echo "Week2_Day5_Player_Properties_Id_ReturnExpectedDataTypes_int FAILED";
        echo "Week2_Day5_Player_Properties_BiddingAmount_ReturnExpectedDataTypes_decimal FAILED";
        echo "Week2_Day6_IndexMethod_PlayerController_Exists FAILED";
        echo "Week2_Day6_IndexMethod_PlayerController_DisplaysAllPlayers FAILED";
        echo "Week3_Day2_Test_IndexViewFile_Exists FAILED";
        echo "Week3_Day2_VerifyIndexRoute FAILED";
        echo "Week3_Day2_VerifyCreateRoute FAILED";
        echo "Week3_Day2_Player_NameIsRequired FAILED";
        echo "Week3_Day2_Player_BiddingAmountMustBeGreaterThanZero FAILED";
        echo "Week3_Day3_Test_LoginViewFile_Exists FAILED";
        echo "Week3_Day3_Test_RegisterViewFile_Exists FAILED";
        echo "Week3_Day3_CreateMethod_PlayerController_Add_Player_to_DB FAILED";
        echo "Week3_Day5_EditMethod_PlayerController_Exists FAILED";
        echo "Week3_Day5_DeleteMethod_PlayerController_Exists FAILED";
        echo "Week3_Day5_Test_CreateViewFile_Exists FAILED";
        echo "Week3_Day5_Test_EditViewFile_Exists FAILED";
        echo "Week3_Day5_DeleteMethod_PlayerController_Delete_Player_from_DB FAILED";
    fi
else
    echo "Week2_day5_Player_ClassExists FAILED";
    echo "Week2_Day5_Player_Properties_Id_ReturnExpectedDataTypes_int FAILED";
    echo "Week2_Day5_Player_Properties_BiddingAmount_ReturnExpectedDataTypes_decimal FAILED";
    echo "Week2_Day6_IndexMethod_PlayerController_Exists FAILED";
    echo "Week2_Day6_IndexMethod_PlayerController_DisplaysAllPlayers FAILED";
    echo "Week3_Day2_Test_IndexViewFile_Exists FAILED";
    echo "Week3_Day2_VerifyIndexRoute FAILED";
    echo "Week3_Day2_VerifyCreateRoute FAILED";
    echo "Week3_Day2_Player_NameIsRequired FAILED";
    echo "Week3_Day2_Player_BiddingAmountMustBeGreaterThanZero FAILED";
    echo "Week3_Day3_Test_LoginViewFile_Exists FAILED";
    echo "Week3_Day3_Test_RegisterViewFile_Exists FAILED";
    echo "Week3_Day3_CreateMethod_PlayerController_Add_Player_to_DB FAILED";
    echo "Week3_Day5_EditMethod_PlayerController_Exists FAILED";
    echo "Week3_Day5_DeleteMethod_PlayerController_Exists FAILED";
    echo "Week3_Day5_Test_CreateViewFile_Exists FAILED";
    echo "Week3_Day5_Test_EditViewFile_Exists FAILED";
    echo "Week3_Day5_DeleteMethod_PlayerController_Delete_Player_from_DB FAILED";
fi
    
